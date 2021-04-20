using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace height_of_bst
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public static Node GenerateBST(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return default;
            }

            int mid = left + (right - left) / 2;
            Node root = new Node();
            root.Data = nums[mid];
            root.Left = GenerateBST(nums, left, mid - 1);
            root.Right = GenerateBST(nums, mid + 1, right);
            return root;
        }

        public static int CalculateBSTHeight(Node root)
        {
            if (root == default) return 0;

            int leftSubTreeHeight = CalculateBSTHeight(root.Left);
            int rightSubTreeHeight = CalculateBSTHeight(root.Right);

            return Math.Max(leftSubTreeHeight, rightSubTreeHeight) + 1;
        }
    }
}
