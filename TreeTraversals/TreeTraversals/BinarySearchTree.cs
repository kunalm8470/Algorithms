using System;

namespace TreeTraversals
{
    /// <summary>
    /// POCO to represent the BST
    /// </summary>
    public class BinarySearchTree
    {
        public Node Root { get; set; } = default(Node);

        public void InOrderTraversal(Node node)
        {
            if (node == default(Node)) return;
            
            InOrderTraversal(node.Left);
            Console.Write("{0}->", node.Item);
            InOrderTraversal(node.Right);
        }

        public void PreOrderTraversal(Node node)
        {
            if (node == default(Node)) return;

            Console.Write("{0}->", node.Item);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(Node node)
        {
            if (node == default(Node)) return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write("{0}->", node.Item);
        }
    }
}
