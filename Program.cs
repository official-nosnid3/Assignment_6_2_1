using System.Xml.Linq;

namespace Assignment_6_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 6.2.1
             * 
             * Write a C# program to implement a stack by using array with push and pop operations.
             */

            Stack stack = new(3);

            stack.PushStack(10);
            stack.PushStack(20);
            stack.PushStack(30);
            stack.PushStack(40);
            stack.PopStack();
            stack.PopStack();
            stack.PopStack();
            stack.PopStack();
        }

        public class Stack
        {
            private int[] _elements;
            private int _topIndex;
            private int _max;

            public Stack(int size)
            {
                _elements = new int[size];
                _topIndex = -1; // empty stack
                _max = size - 1;
            }

            // Push an element onto the stack
            public void PushStack(int element)
            {
                if (_topIndex == _max)
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }
                _elements[++_topIndex] = element;
                Console.WriteLine($"Pushed {element} onto the stack");
            }

            // Pop an element from the stack
            public int PopStack()
            {
                if ( _topIndex == -1)
                {
                    Console.WriteLine("Stack Underflow");
                    return -1;
                }
                Console.WriteLine($"Popped {_elements[_topIndex]} from the stack");
                return _elements[_topIndex--];
            }
        }
    }
}
