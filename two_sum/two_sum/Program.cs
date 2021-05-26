using System.Collections.Generic;

namespace two_sum
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = { -1, -1 };
            if (nums == default || nums.Length == 0)
            {
                return res;
            }

            Dictionary<int, int> lookup = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (lookup.TryGetValue(complement, out int idx))
                {
                    res[0] = i;
                    res[1] = idx;
                    return res;
                }
                lookup[nums[i]] = i;
            }

            return res;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 2, 7, 11, 15 };
            int target1 = 9;

            int[] res1 = TwoSum(arr1, target1);
        }
    }
}
