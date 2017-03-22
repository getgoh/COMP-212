using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stack<T>
    {
        private int top;
        private T[] elements;

        // parameterless constructor
        public Stack() : this(10) // default stack size
        {

        }

        public Stack(int stackSize)
        {
            if(stackSize < 0)
            {
                throw new ArgumentException("Stack size must be positive");
            }

            elements = new T[stackSize]; // create stackSize elements
            top = -1; // stack initially empty

        }

        public void Push(T pushValue)
        {
            if (top == elements.Length - 1) // stack is full
            {
                throw new FullStackException("Stack is full, cannot push " + pushValue);
            }

            ++top; //increment top
            elements[top] = pushValue;
        }

        public T Pop()
        {
            if (top == -1) // stack is empty
            {
                throw new EmptyStackException("Stack is empty, cannot pop");
            }

            --top; // decrement top
            return elements[top + 1]; // return top value
        }
    }
}
