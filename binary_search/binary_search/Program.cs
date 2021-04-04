using System;

namespace binary_search
{
    class Program
    {
        public static int BinarySearch(int[] arr, int item)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (item > arr[left])
                {
                    left++;
                }
                else if (item < arr[right])
                {
                    right--;
                }
                else
                {
                    return mid;
                }
            }

            throw new ArgumentException($"{nameof(item)} not found", nameof(item));
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 12, 13, 16, 17, 22, 24 };
            int item = 17;
            int idx = BinarySearch(arr, item);
        }
    }
}
