using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                double currentNumber = input[i];
                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers[currentNumber] = 0;
                }
                numbers[currentNumber] += 1;
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
