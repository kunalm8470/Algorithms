using System;

namespace deleting_occurences_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> sl = new SingleLinkedList<int>();
            sl.AddLast(1).AddLast(2).AddLast(3).AddLast(4).AddLast(5);
            
            sl.Remove(2);

            foreach (Node<int> item in sl)
            {
                Console.WriteLine(item.Data);
            }
            
        }
    }
}
