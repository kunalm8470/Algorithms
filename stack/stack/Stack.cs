using System;

namespace stack
{
    public class Stack
    {
        private int[] _values;
        private int _count = 0;
        private static readonly int DEFAULT_SIZE = 4;

        // Constructors
        public Stack(int capacity)
        {
            _values = new int[capacity];
            _count = 0;
        }

        public Stack() : this(DEFAULT_SIZE) { }
        
        public int Count 
        {
            get
            {
                return _count;
            }
        }

        public int Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Empty stack!");
            }

            return _values[_count - 1];
        }

        public void Push(int item)
        {
            if (_count == _values.Length)
            {
                Array.Resize(ref _values, 2 * _values.Length);
            }
                
            _values[_count++] = item;
        }

        public int Pop()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Empty stack!");
            }

            int result = _values[--_count];
            _values[_count] = default(int);
            return result;
        }
    }
}
