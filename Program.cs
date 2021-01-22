using LinkedStack.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new My_Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Stack<string> words = new Stack<string>();
            words.Push("Water");
            words.Push("Fire");
            words.Clear();
            Console.WriteLine();
            var arrayStack = new ArrayStack<int>(5);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(400);
            arrayStack.Push(500);
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());

            Console.ReadKey();
        }
    }
}
