using System;

namespace selection_sort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minimum = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] <= arr[minimum])
                    {
                        minimum = j;
                    }
                }

                if (minimum != i)
                {
                    Swap(ref arr[i], ref arr[minimum]);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 5, 3, 9, 4, 1 };
            SelectionSort(arr);
        }
    }
}
