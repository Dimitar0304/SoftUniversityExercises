using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<string, int, bool> CheckFirstOccurInList = (name, sum) =>
               {
                   int currentSum = 0;
                   for (int i = 0; i < name.Length; i++)
                   {
                       currentSum += name[i];
                   }
                   if (sum <= currentSum)
                   {
                       return true;
                   }
                   return false;
               };
            foreach (var item in names)
            {
                if (CheckFirstOccurInList(item, sum)==true)
                {
                    Console.WriteLine(item);
                    return;
                }
            }
        }
    }
}
