using System;

namespace bubble_sort
{
    public static class BubbleSortExtensions
    {
        public static void BubbleSort<T>(this T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i].CompareTo(arr[j]) > 0)
                        Swap(ref arr[i], ref arr[j]);
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
