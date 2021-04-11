namespace tree_operations
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public static Node Insert(Node root, int data)
        {
            if (root == default)
            {
                return new Node
                {
                    Data = data
                };
            }

            if (root.Data > data)
            {
                root.Left = Insert(root.Left, data);
            }
            else
            {
                root.Right = Insert(root.Right, data);
            }

            return root;
        }

        public static Node Search(Node root, int key)
        {
            if (root == default || root.Data == key) return root;

            if (root.Data > key) return Search(root.Left, key);

            return Search(root.Right, key);
        }
    }
}
