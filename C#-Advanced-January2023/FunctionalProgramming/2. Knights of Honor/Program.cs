using System;

namespace _2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string extention = "Sir";
            Action<string[]> printNames = (names) => Console.WriteLine("Sir "+string.Join(Environment.NewLine+$"{extention} ",names));

            printNames(names);
        }
    }
}
