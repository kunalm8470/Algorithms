using System;
using System.Collections;
using System.Collections.Generic;

namespace stack
{
    public class StackImpl<T> : IEnumerable<T>
    {
        private T[] _values;
        private int _length = 0;
        private static readonly int DEFAULT_SIZE = 4;

        public StackImpl(int capacity)
        {
            _values = new T[capacity];
            _length = 0;
        }

        public StackImpl() : this(DEFAULT_SIZE) { }
        
        public int Count 
        {
            get
            {
                return _length;
            }
        }

        public T Peek()
        {
            if (_length == 0) throw new InvalidOperationException("Empty stack!");

            return _values[_length - 1];
        }

        public StackImpl<T> Push(T item)
        {
            if (_length == _values.Length)
                Array.Resize(ref _values, 2 * _values.Length);
                
            _values[_length++] = item;
            return this;
        }

        public T Pop()
        {
            if (_length == 0)
                throw new InvalidOperationException("Empty stack!");

            T result = _values[_length - 1];
            _values[_length - 1] = default;
            _length--;
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int size = _length - 1;
            while (size >= 0)
            {
                yield return _values[size];
                --size;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
