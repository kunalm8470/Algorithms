using System;

namespace TreeTraversals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bootstrap BST
             * 
             *       1
             *       /\
             *      2  3
             *         /\
             *        4  5
             *        
            */ 
            BinarySearchTree bst = new BinarySearchTree();
            bst.Root = new Node(1);
            bst.Root.Left = new Node(2);
            bst.Root.Right = new Node(3);
            bst.Root.Left.Left = new Node(4);
            bst.Root.Left.Right = new Node(5);

            Console.WriteLine("In-order traversal of BST");
            bst.InOrderTraversal(bst.Root);

            Console.WriteLine();

            Console.WriteLine("Pre-order traversal of BST");
            bst.PreOrderTraversal(bst.Root);

            Console.WriteLine();

            Console.WriteLine("Post order traversal of BST");
            bst.PostOrderTraversal(bst.Root);
        }
    }
}
