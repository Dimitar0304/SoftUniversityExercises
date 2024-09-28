using System;
using System.Linq;

namespace _04_AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n)).ToArray();

            AddVAT(numbers);
        }

        private static void AddVAT(double[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine($"{ item + item * 0.20:F2}");
            }
        }
    }
}
