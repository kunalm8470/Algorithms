namespace reverse_linked_list
{
    public class Node
    {
        public int Data { get; }
        public Node Next { get; }

        public Node(int data, Node next)
        {
            Data = data;
            Next = next;
        }

        public static Node Reverse(Node head)
        {
            if (head == default) return default;

            if (head.Next == default) return head;

            Node current = head;
            Node reverse = default;

            while (current.Next != default)
            {
                reverse = new Node(current.Data, reverse);
                current = current.Next;
            }

            reverse = new Node(current.Data, reverse);
            return reverse;
        }
    }
}
