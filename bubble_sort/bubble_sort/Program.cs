using System;

namespace bubble_sort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 6, 3, 7, 1, 0 };
            BubbleSort(arr);
        }
    }
}
