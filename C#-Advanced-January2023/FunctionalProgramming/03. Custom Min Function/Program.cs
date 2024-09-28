using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            

            Func<int[], int> SmallestNumber = (int[] number) => number.Min();

            Console.WriteLine(SmallestNumber(numbers));
        }
    }
}
