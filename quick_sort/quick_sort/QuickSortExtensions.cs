using System;

namespace quick_sort
{
    public static class QuickSortExtensions
    {
        public static void QuickSort<T>(this T[] arr) where T : IComparable
        {
            quickSort(arr, 0, arr.Length - 1);
        }

        static void quickSort<T>(T[] arr, int left, int right) where T : IComparable
        {
            if (left >= right) return;

            int partitionIndex = Partition(arr, left, right);
            quickSort(arr, left, partitionIndex);
            quickSort(arr, partitionIndex + 1, right);
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Hoare's partition algorithm - https://en.wikipedia.org/wiki/Quicksort#Hoare_partition_scheme
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="left">Left index</param>
        /// <param name="right">Right index</param>
        /// <returns>Partition index (i.e index of the pivot element which is in correct sorted order)</returns>
        static int Partition<T>(T[] arr, int left, int right) where T : IComparable
        {
            T pivot = arr[left];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                // Increment until found a number larger than pivot
                do
                {
                    i += 1;
                } while (arr[i].CompareTo(pivot) < 0);

                // Decrement until found a number smaller than pivot
                do
                {
                    j -= 1;
                } while (arr[j].CompareTo(pivot) > 0);

                /*
                 * At this point left has crossed right, break out
                 * of the loop
                 * 
                 * Pivot will be now at the correct sorted position
                 * and elements to the left of pivot will be smaller
                 * and to the right will be greater
                */
                if (i >= j) return j;

                /*
                 * Swap the first-or-default value larger than the pivot
                 * with the first-or-default value smaller than the pivot
                */
                Swap(ref arr[i], ref arr[j]);
            }
        }
    }
}
