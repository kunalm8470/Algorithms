using printing_leaf_nodes.Models;
using System;

namespace printing_leaf_nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 10, 12, 15, 16, 20, 25 };
            Node bstRoot = Node.GenerateBST(arr, 0, arr.Length - 1);

            Node.PrintLeafNodes(bstRoot);
        }
    }
}
