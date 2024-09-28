using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = string.Empty;
            Action<List<int>> printList = numbers => Console.WriteLine(string.Join(" ",numbers));

            

            Func<List<int>, string, List<int>> commandFunc = (numbers, command) =>
              {
                   List<int> result = new List<int>();
                  switch (command)
                  {
                      case"add":
                          foreach (var number in numbers)
                          {
                              result.Add(number + 1);
                          }
                          break;
                         
                      case "subtract":
                          foreach (var number in numbers)
                          {
                              result.Add(number - 1);
                          }
                          break;
                      case "multiply":
                          foreach (var number in numbers)
                          {
                              result.Add(number * 2);
                          }

                          break;
                  }
                  
                  return result;
              };

            while ((command = Console.ReadLine())!="end")
            {
                if (command=="print")
                {
                    printList(numbers);
                }
                else
                {
                     numbers = commandFunc(numbers, command);
                }
            }

        }
    }
}
