using System;

namespace median_of_2_sorted_arrays
{
    class Program
    {
		public static int[] MergeArrays(int[] nums1, int[] nums2)
		{
			int[] res = new int[nums1.Length + nums2.Length];

			int i = 0, j = 0, k = 0;

			while (i < nums1.Length && j < nums2.Length)
			{
				if (nums1[i] < nums2[j])
				{
					res[k++] = nums1[i++];
				}
				else
				{
					res[k++] = nums2[j++];
				}
			}

			while (i < nums1.Length)
			{
				res[k++] = nums1[i++];
			}

			while (j < nums2.Length)
			{
				res[k++] = nums2[j++];
			}

			return res;
		}

		public double FindMedianSortedArraysBruteForce(int[] nums1, int[] nums2)
		{
			int[] merged = MergeArrays(nums1, nums2);
			if (merged.Length % 2 == 0)
			{
				int mid = merged[merged.Length / 2];
				int midPlusOne = merged[(merged.Length + 1) / 2];
				return ((double)mid + (double)midPlusOne) / 2;
			}
			else
			{
				return (double)merged[merged.Length / 2];
			}
		}

		/// <summary>
		/// https://www.youtube.com/watch?v=uPqPDPjtPX4 See explanation for O(log(m + n)) solution
		/// </summary>
		/// <param name="nums1"></param>
		/// <param name="nums2"></param>
		/// <returns></returns>
		public static double FindMedianSortedArraysOptimized(int[] nums1, int[] nums2)
		{
			if (nums1.Length > nums2.Length)
			{
				return FindMedianSortedArraysOptimized(nums2, nums1);
			}

			int lengthA = nums1.Length;
			int lengthB = nums2.Length;
			int combinedLength = lengthA + lengthB;

			int low = 0;
			int high = lengthA;

			while (low <= high)
			{
				int partitionA = (low + high) / 2;
				int partitionB = ((combinedLength + 1) / 2) - partitionA;

				int maxLeftA = (partitionA == 0) ? int.MinValue : nums1[partitionA - 1];
				int minRightA = (partitionA == lengthA) ? int.MaxValue : nums1[partitionA];

				int maxLeftB = (partitionB == 0) ? int.MinValue : nums2[partitionB - 1];
				int minRightB = (partitionB == lengthB) ? int.MaxValue : nums2[partitionB];

				if (maxLeftA <= minRightB && maxLeftB <= minRightA)
				{
					// For even length(s)
					if (combinedLength % 2 == 0)
					{
						return ((double)Math.Max(maxLeftA, maxLeftB) + (double)Math.Min(minRightA, minRightB)) / 2;
					}
					else
					{
						return (double)Math.Max(maxLeftA, maxLeftB);
					}
				}
				else if (maxLeftA > minRightB)
				{
					high = partitionA - 1;
				}
				else
				{
					low = partitionA + 1;
				}
			}

			throw new ArgumentException();
		}

		static void Main(string[] args)
        {
			int[] nums1 = { 1, 3, 5, 7 }, nums2 = { 2, 4, 6, 8, 10 };
			double medianRes1 = FindMedianSortedArraysOptimized(nums1, nums2);
		}
    }
}
