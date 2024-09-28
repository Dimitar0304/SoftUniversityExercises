using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] StartAndEndInt = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            int startInt = StartAndEndInt[0];
            int end = StartAndEndInt[1];

            string EvenOrOdd = Console.ReadLine();
            initalizeTheNumbers(startInt, end, result);
            SortNumbers(EvenOrOdd, result);

            static List<int>  initalizeTheNumbers(int startInt,int end,List<int> result)
            {
                for (int i = startInt; i <= end; i++)
                {
                    result.Add(i);
                }
                return result.ToList();
            }
        }

        private static void SortNumbers(string evenOrOdd, List<int> result)
        {
            if (evenOrOdd =="odd")
            {
                foreach (var item in result.Where(n=>n%2 ==1))
                {
                    Console.Write($"{item} ");
                }
            }
            else if (evenOrOdd == "even")
            {
                foreach (var item in result.Where(n => n % 2 == 0))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}

