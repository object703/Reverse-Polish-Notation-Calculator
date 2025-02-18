using System;
using System.Windows.Forms;

namespace RPN
{
    internal class ArrayStack<T> : IStack<T>
    {
        private T[] _array;
        private int _top = -1;
        private int _length = 10;

        /// <summary>
        /// Constructor. Array length hardcoded for now
        /// </summary>
        public ArrayStack()
        {
            _array = new T[_length];
        }


        /// <summary>
        /// Method for checking if stack is empty
        /// </summary>
        /// <returns>true, false</returns>
        public bool IsEmpty() => _top == -1;


        /// <summary>
        /// Method for checking if stack is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull() => _top == _length;


        /// <summary>
        /// Method to add new item and increment _top
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (IsFull())
                throw new IndexOutOfRangeException("stack is full!");
            else
                _array[++_top] = item;
        }


        /// <summary>
        /// Method to retrieve most recent item, before decrementing _top
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("empty stack!");

            return _array[_top--];
        }

        /// <summary>
        /// Method to access the most recent item
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("empty stack!");

            return _array[_top];
        }
    }
}
