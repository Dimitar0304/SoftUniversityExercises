using System;
using System.Linq;

namespace _02_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(",").Select(n => int.Parse(n)).ToArray();

            PrintResult(numbers);
           
        }

        public static void PrintResult(int[] numbers)
        {
            Console.WriteLine(numbers.Length);
            Console.WriteLine(SumOfSequance(numbers));
        }

        public static int SumOfSequance(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
