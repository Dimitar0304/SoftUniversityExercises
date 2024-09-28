using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            

            Func<List<string>, int, List<string>> CheckEachName = (names, n) =>
               {
                   List<string> result = new List<string>();
                   foreach (var name in names)
                   {
                       if (name.Length<=n)
                       {
                           result.Add(name);
                       }
                   }
                   return result;
               };

            Action<List<string>> printList = names =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            };

             names = CheckEachName(names, n);

            printList(names);

        }
    }
}
