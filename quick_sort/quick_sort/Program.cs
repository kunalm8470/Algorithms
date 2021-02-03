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
            quickSort(arr, left, partitionIndex - 1);
            quickSort(arr, partitionIndex + 1, right);
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                do
                {
                    i += 1;
                } while (arr[i] < pivot);

                do
                {
                    j -= 1;
                } while (arr[j] > pivot);

                if (i >= j)
                {
                    return j;
                }

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
            int[] arr = { 2, 6, 5, 3, 8, 7, 1, 0 };
            QuickSort(arr);
        }
    }
}
