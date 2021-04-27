using System;

namespace doubly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> ll = new DoubleLinkedList<int>();
            ll.AddLast(1).AddLast(2).AddLast(3).AddLast(4).AddLast(5).AddLast(6);

            ll.Remove(3).Remove(5);
            foreach (Node<int> item in ll)
            {
                Console.WriteLine(item.Data);
            }

            ll.RemoveFirst();
            foreach (Node<int> item in ll)
            {
                Console.WriteLine(item.Data);
            }
        }
    }
}
