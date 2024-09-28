using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> swordAmount = new Dictionary<string, int>(); 
            int[] steelInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] carbonInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int countOfSwords = 0;

            Queue<int> steels = new Queue<int>(steelInput);
            Stack<int> carbons = new Stack<int>(carbonInput);

            while (steels.Count!=0&&carbons.Count!=0)
            {
                int currentSteel = steels.Dequeue();
                int currentCarbon = carbons.Pop();

                int sum = currentSteel + currentCarbon;

                if (sum==70)
                {
                    if (!swordAmount.ContainsKey("Gladius"))
                    {
                        swordAmount.Add("Gladius", 0);
                    }
                    swordAmount["Gladius"]++;
                    countOfSwords++;
                }
                else if (sum==80)
                {
                    if (!swordAmount.ContainsKey("Shamshir"))
                    {
                        swordAmount.Add("Shamshir", 0);
                    }
                    swordAmount["Shamshir"]++;
                    countOfSwords++;
                }
                else if (sum==90)
                {
                    if (!swordAmount.ContainsKey("Katana"))
                    {
                        swordAmount.Add("Katana", 0);
                    }
                    swordAmount["Katana"]++;
                    countOfSwords++;
                }
                else if (sum ==110)
                {
                    if (!swordAmount.ContainsKey("Sabre"))
                    {
                        swordAmount.Add("Sabre", 0);
                    }
                    swordAmount["Sabre"]++;
                    countOfSwords++;
                }
                else if (sum==150)
                {
                    if (!swordAmount.ContainsKey("Broadsword"))
                    {
                        swordAmount.Add("Broadsword", 0);
                    }
                    swordAmount["Broadsword"]++;
                    countOfSwords++;
                }
                else
                {
                    currentCarbon += 5;
                    carbons.Push(currentCarbon);
                }
            }

            if (swordAmount.Count==0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {countOfSwords} swords.");
            }

            if (steels.Count==0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                List<int> result = new List<int>(steels);
                if (result.Count==1)
                {
                    Console.WriteLine($"Steel left: {string.Join("",result)}");
                }
                else
                {
                    Console.WriteLine($"Steel left: {string.Join(", ",result)}");
                }
            }

            if (carbons.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                List<int> result = new List<int>(carbons);
                if (result.Count == 1)
                {
                    Console.WriteLine($"Carbon left: {string.Join("", result)}");
                }
                else
                {
                    Console.WriteLine($"Carbon left: {string.Join(", ", result)}");
                }
            }

            foreach (var sword in swordAmount.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{sword.Key}: {sword.Value}");
            }
        }
    }
}
