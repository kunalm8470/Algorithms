using System;

namespace tree_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node
            {
                Data = 5,
                Left = new Node
                {
                    Data = 2
                },
                Right = new Node
                {
                    Data = 7
                }
            };

            root = Node.Insert(root, 1);
            root = Node.Insert(root, 4);
            root = Node.Insert(root, 6);
            root = Node.Insert(root, 9);

            Node found = Node.Search(root, 6);
        }
    }
}
