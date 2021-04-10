using System;

namespace reverse_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = default;
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                head = new Node(arr[i], head);
            }

            Node reversed = Node.Reverse(head);
        }
    }
}
