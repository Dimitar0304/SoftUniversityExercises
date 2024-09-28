using System;

namespace _02CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            stack.ForEach(e => Console.WriteLine(e));
        }
    }
}
