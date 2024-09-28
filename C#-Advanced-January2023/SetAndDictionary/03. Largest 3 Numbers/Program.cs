using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> elements = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNUumber = numbers[i];

                if (!elements.ContainsKey(currentNUumber))
                {
                    elements[currentNUumber] = 0;
                }
            }
            int[]  sorted= numbers.OrderByDescending(n => n).ToArray();
            if (sorted.Length<3)
            {
                Console.WriteLine(string.Join(" ",sorted));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{sorted[i]} ");
                }
            }
           
        }
    }
}
