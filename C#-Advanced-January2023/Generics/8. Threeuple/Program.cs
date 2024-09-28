using System;
using System.Linq;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drinkTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] bankTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string, string> person =
                new Tuple<string, string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));

            Tuple<string, int, bool> drinks =
                new Tuple<string, int, bool>(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

            Tuple<string, double, string> bank =
                new Tuple<string, double, string>(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

            Console.WriteLine(person);
            Console.WriteLine(drinks);
            Console.WriteLine(bank);
        }
    }
}
