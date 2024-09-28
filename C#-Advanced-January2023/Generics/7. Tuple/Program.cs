using System;
using System.Linq;

namespace CustomTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drinks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Tuple<string, string> nameTuple = new Tuple<string, string>(names[0] + names[1], names[2]);

            Tuple<string, int> drinkTuple = new Tuple<string, int>(drinks[0], int.Parse(drinks[1]));

            Tuple<int, int> numbersTuple = new Tuple<int, int>(numbers[0], numbers[1]);

            Console.WriteLine(nameTuple.ToString());
            Console.WriteLine(drinkTuple.ToString());
            Console.WriteLine(numbersTuple.ToString());
        }
    }
}
