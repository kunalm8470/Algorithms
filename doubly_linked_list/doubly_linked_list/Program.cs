﻿using System;

namespace doubly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> ll = new DoubleLinkedList<int>();
            ll.InsertRear(1).InsertRear(2).InsertRear(3).InsertRear(4).InsertRear(5).InsertRear(6);

            ll.Delete(3).Delete(5);
            foreach (Node<int> item in ll)
            {
                Console.WriteLine(item.Data);
            }

            ll.DeleteFront();
            foreach (Node<int> item in ll)
            {
                Console.WriteLine(item.Data);
            }
        }
    }
}
