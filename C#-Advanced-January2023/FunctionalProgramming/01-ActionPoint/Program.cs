using System;

namespace _01_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> printString = (names) => Console.WriteLine(String.Join(Environment.NewLine,names));
            printString(names);
        }
    }
}
