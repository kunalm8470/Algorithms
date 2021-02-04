using System;

namespace quick_sort
{
    class Program
    {
        static void QuickSort(int[] arr)
        {
            quickSort(arr, 0, arr.Length - 1);
        }

        static void quickSort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int partitionIndex = Partition(arr, left, right);
            quickSort(arr, left, partitionIndex);
            quickSort(arr, partitionIndex + 1, right);
        }

        /// <summary>
        /// Hoare's partition algorithm
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="left">Left index</param>
        /// <param name="right">Right index</param>
        /// <returns>Partition index (i.e index of the pivot element which is in correct sorted order)</returns>
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                // Increment until found a number larger than pivot
                do
                {
                    i += 1;
                } while (arr[i] < pivot);

                // Decrement until found a number smaller than pivot
                do
                {
                    j -= 1;
                } while (arr[j] > pivot);

                /*
                 * At this point left has crossed right, break out
                 * of the loop
                 * 
                 * Pivot will be now at the correct sorted position
                 * and elements to the left of pivot will be smaller
                 * and to the right will be greater
                */
                if (i >= j)
                {
                    return j;
                }

                /*
                 * Swap the first-or-default value larger than the pivot
                 * with the first-or-default value smaller than the pivot
                */
                Swap(ref arr[i], ref arr[j]);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int[] arr = { -1, -2, -1, -3, -3, 14, 6, 8, 1, 4, 9, 2, 0, 1, 7, 10, 5 };
            QuickSort(arr);
        }
    }
}
