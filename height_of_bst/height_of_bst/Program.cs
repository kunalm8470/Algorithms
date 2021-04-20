using System;

namespace height_of_bst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 10, 12, 15, 16, 20, 25 };
            Node bstRoot = Node.GenerateBST(arr, 0, arr.Length - 1);

            int bstHeight = Node.CalculateBSTHeight(bstRoot);
        }
    }
}
