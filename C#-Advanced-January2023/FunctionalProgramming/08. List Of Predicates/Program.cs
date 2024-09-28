using System;
using System.Collections.Generic;
using System.Linq;  

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            HashSet<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            int[] collection = Enumerable.Range(1, range).ToArray();
            List<int> result = new List<int>();

            //from all range we will found a numbers wich will divisible by each one of dividers

           

            Func<HashSet<int>, int, List<int>> FuncAllNumbers = (dividers,  currentNumber) =>
              {
                  bool isDivisible = true;
                  foreach (var divider in dividers)
                  {
                      if (currentNumber % divider !=0)
                      {
                          isDivisible = false;
                          break;
                      }
                    
                  }
                  if (isDivisible)
                  {
                      result.Add(currentNumber);
                  }
                  return result;
              };

            foreach (var number in collection)
            {
                FuncAllNumbers(dividers, number);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
