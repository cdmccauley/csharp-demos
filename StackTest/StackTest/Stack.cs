using System;

namespace StackTest
{
    // all code from book
    class Stack<T>
    {
        private int top;
        private T[] elements;

        public Stack() : this(10)
        {
        }

        public Stack(int stackSize)
        {
            if (stackSize > 0)
                elements = new T[stackSize];
            else
                throw new ArgumentException("Stack size must be positive.");
            top = -1;
        }

        public void Push(T pushValue)
        {
            if (top == elements.Length - 1)
                throw new FullStackException(string.Format("Stack is full, cannot push {0}", pushValue));
            ++top;
            elements[top] = pushValue;
        }

        public T Pop()
        {
            if (top == -1)
                throw new EmptyStackException("Stack is empty, cannot pop");
            --top;
            return elements[top + 1];
        }
    }

    class FullStackException : Exception
    {
        public FullStackException() : base("Stack is full")
        {
        }

        public FullStackException(string exception) : base(exception)
        {
        }

        public FullStackException(string exception, Exception inner) : base(exception, inner)
        {
        }
    }

    class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Stack is empty")
        {
        }

        public EmptyStackException(string exception) : base(exception)
        {
        }

        public EmptyStackException(string exception, Exception inner) : base(exception, inner)
        {
        }
    }
}
