﻿namespace stackexample
{
    public class Stack<T> : IStack<T>
    {
        private readonly T[] values;

        private int top;

        public Stack(int capacity)
        {
            values = new T[capacity];
            top = -1;
        }

        public int Capacity()
        {
            return values.Length;
        }

        public void Clear()
        {
            top = -1;
        }

        public int Height()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return Height() == 0;
        }

        public bool IsFull()
        {
            return top == Capacity();
        }

        public void Pop()
        {
            if (top >= 0)
            {
                top--;
            }
        }

        public void Push(T value)
        {
            top++;
            values[top] = value;
        }

        public T Top()
        {
            if (top >= 0)
            {
                return values[top];
            }
            else
            {
                return default;
            }
        }
    }
}

