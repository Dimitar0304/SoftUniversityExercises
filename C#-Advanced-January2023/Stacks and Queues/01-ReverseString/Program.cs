using System;
using System.Collections.Generic;

namespace _01_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string normalText = Console.ReadLine();
            Stack<char> reversedString = new Stack<char>();
            for (int i = 0; i < normalText.Length; i++)
            {
                reversedString.Push(normalText[i]);
            }
            while (reversedString.Count!=0)
            {
                Console.Write(reversedString.Pop());
            }
        }
    }
}
