using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            stack.Push(5);
            stack.Peek();
            Console.WriteLine("Stack size: " + stack.Height);
            stack.Push(10);
            Console.WriteLine("Stack size: " + stack.Height);
            stack.Peek();
            stack.Push(15);
            Console.WriteLine("Stack size: " + stack.Height);
            stack.Peek();
            stack.Pop();
            Console.WriteLine("Stack size: " + stack.Height);
            stack.Peek();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Stack size: " + stack.Height);
            stack.Peek();
        }
    }
}
