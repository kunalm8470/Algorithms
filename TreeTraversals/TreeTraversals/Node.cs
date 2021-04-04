namespace TreeTraversals
{
    /// <summary>
    /// POCO to represent each node in the BST
    /// </summary>
    public class Node
    {
        public int Item { get; set; }
        public Node Left { get; set; } = default(Node);
        public Node Right { get; set; } = default(Node);

        public Node(int item)
        {
            this.Item = item;
        }
    }
}
