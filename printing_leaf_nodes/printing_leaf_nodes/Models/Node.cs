using System;

namespace printing_leaf_nodes.Models
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public static Node GenerateBST(int[] arr, int left, int right)
        {
            if (left > right) return default;
            
            int mid = left + (right - left) / 2;
            Node root = new Node
            {
                Data = arr[mid]
            };
            
            root.Left = GenerateBST(arr, left, mid - 1);
            root.Right = GenerateBST(arr, mid + 1, right);
            return root;
        }

        public static void PrintLeafNodes(Node root)
        {
            if (root == default) return;

            /*
             * Leaf nodes have left and right nodes as null
            */
            if (root.Left == default && root.Right == default)
            {
                Console.Write("{0} ", root.Data);
            }

            // Recurse into left subtree
            PrintLeafNodes(root.Left);

            // Recurse into right subtree
            PrintLeafNodes(root.Right);
        }
    }
}
