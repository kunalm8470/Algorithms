using System;

namespace selection_sort
{
    public static class SelectionSortExtensions
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void SelectionSort<T>(this T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minimum = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[minimum]) < 0)
                        minimum = j;
                }

                if (minimum != i)
                    Swap(ref arr[i], ref arr[minimum]);
            }
        }
    }
}
