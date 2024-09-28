using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
 
List<int> reversedResult = new List<int>();
            Func<List<int>, List<int>> reverseArray = result =>
             {
                 
                 for (int i = result.Count-1; i >= 0; i--)
                 {
                     reversedResult.Add(result[i]);
                 }
                 return reversedResult;
             };
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int divider = int.Parse(Console.ReadLine());
            Predicate<int> predicateNumbersInArray = n => n % divider != 0;
            Func<int[], Predicate<int>, List<int>> funcForEachNumber = (numbers, match) =>
             {
                 foreach (var number in numbers)
                 {
                     if (match(number))
                     {
                         result.Add(number);
 
                     }
                 }
                 return result;
             };

            funcForEachNumber(numbers, predicateNumbersInArray);
            reverseArray(result);
            Console.WriteLine($"{string.Join(" ",reversedResult)}");
        }
    }
}
