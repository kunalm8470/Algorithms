namespace reverse_linked_list
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public static Node Reverse(Node head)
        {
            if (head == default) return default;

            if (head.Next == default) return head;

            Node current = head;
            Node prev = default;
            Node next = default;
             
            // null -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null
            while (current != default)
            {
                // Save next
                next = current.Next;
                
                // Reverse
                current.Next = prev;
                
                // Advance previous
                prev = current;

                // Advance current
                current = next;
            }

            return prev;
        }
    }
}
