using System;

namespace RPN
{
    internal class ArrayStack<T> : IStack<T>
    {
        private T[] _array;
        private int _top;
        private readonly int _length = 10;

        public ArrayStack()
        {
            _array = new T[_length];
            _top = -1;
        }

        /// <summary>
        /// Method for checking if stack is empty
        /// </summary>
        /// <returns>true, false</returns>
        public bool IsEmpty() => _top == -1;
        public bool IsFull() => _top == _length;

        /// <summary>
        /// Method to access the most recent element. No modifications
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("empty stack!");
            }

            return _array[_top];
        }

        /// <summary>
        /// Method to retrieve element
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("empty stack!");
            }

            return _array[_top--];
        }

        /// <summary>
        /// Method to add new item and increment _top
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (IsFull())
            {
                throw new IndexOutOfRangeException("stack is full!");
            }
            else
            {
                _top += 1;
                _array[_top] = item;
            }
        }
    }
}
