using System;

namespace _03_CountUpperCaseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            PrintUpperCaseWord(text);
        }

        private static void PrintUpperCaseWord(string[] text)
        {
            foreach (var item in text)
            {
                if (char.IsUpper(item[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
