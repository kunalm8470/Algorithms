using System.Collections;
using System.Collections.Generic;

namespace deleting_occurences_linked_list
{
    public class SingleLinkedList<T> : IEnumerable<Node<T>>
    {
        private Node<T> _head;
        public Node<T> First
        {
            get
            {
                return _head;
            }
        }

        private Node<T> _tail;
        public Node<T> Last
        {
            get
            {
                return _tail;
            }
        }

        private int _length;
        public int Count
        {
            get
            {
                return _length;
            }
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> current = _head;
            while(current != default)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public SingleLinkedList<T> AddLast(T data)
        {
            Node<T> newNode = new Node<T>
            {
                Data = data
            };

            if (_head == default)
            {
                _head = newNode;
            }
            else
            {
                // Before
                // 1 -> null

                // After
                // 1 -> 2 -> null
                _tail.Next = newNode;
            }

            _tail = newNode;
            _length++;
            return this;
        }

        public SingleLinkedList<T> Remove(T data)
        {
            if (_head == default) return this;

            // If LL contains single node
            if (_head == _tail && _head.Data.Equals(data))
            {
                _head = default;
                _tail = default;
                _length--;
                return this;
            }

            Node<T> current = _head;
            Node<T> previous = default;
            while(current != default && !current.Data.Equals(data))
            {
                previous = current;
                current = current.Next;
            }

            // Element not found
            if (previous == default || current == default) return this;

            //Before
            // 1 -> 2 -> 3 -> 4 -> 5 -> null
            // if data = 3

            // After
            // current
            previous.Next = current.Next;
            current.Next = default;
            _length--;
            return this;
        }
    }
}
