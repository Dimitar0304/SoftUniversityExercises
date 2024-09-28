using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] textileInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] medicamentsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Dictionary<string, int> healProductsAmount = new Dictionary<string, int>();
            Queue<int> textile = new Queue<int>(textileInput);
            Stack<int> medicaments = new Stack<int>(medicamentsInput);

            while (textile.Count!=0&&medicaments.Count!=0)
            {
                int currentTetile = textile.Dequeue();
                int currentMedicament = medicaments.Pop();

                int sum = currentTetile + currentMedicament;
                if (sum ==30)
                {
                    if (!healProductsAmount.ContainsKey("Patch"))
                    {
                        healProductsAmount.Add("Patch", 0);
                    }
                    healProductsAmount["Patch"]++;
                }
                else if (sum==40)
                {
                    if (!healProductsAmount.ContainsKey("Bandage"))
                    {
                        healProductsAmount.Add("Bandage", 0);
                    }
                    healProductsAmount["Bandage"]++;
                }
                else if (sum==100)
                {
                    if (!healProductsAmount.ContainsKey("MedKit"))
                    {
                        healProductsAmount.Add("MedKit", 0);
                    }
                    healProductsAmount["MedKit"]++;
                }
                else if (sum>100)
                {
                    int itemToInsertInMedicaments = sum - 100;
                    int lastElement = medicaments.Pop();
                    lastElement += itemToInsertInMedicaments;
                    medicaments.Push(lastElement);
                    if (!healProductsAmount.ContainsKey("MedKit"))
                    {
                        healProductsAmount.Add("MedKit", 0);
                    }
                    healProductsAmount["MedKit"]++;
                }
                else
                {
                    currentMedicament += 10;
                    medicaments.Push(currentMedicament);
                }
            }

            if (textile.Count==0&&medicaments.Count>0)
            {
                Console.WriteLine("Textiles are empty.");
            }
            else if (medicaments.Count==0&&textile.Count>0)
            {
                Console.WriteLine("Medicaments are empty.");
            }
            else if (medicaments.Count==0&&textile.Count==0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }

            if (healProductsAmount.Count>0)
            {
                foreach (var item in healProductsAmount.OrderByDescending(i=>i.Value).ThenBy(i=>i.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }

            if (medicaments.Count>0)
            {
                List<int> result = new List<int>(medicaments);
                if (medicaments.Count==1)
                {
                    Console.WriteLine($"Medicaments left: {string.Join("",result)}");
                }
                else
                {
                    Console.WriteLine($"Medicaments left: {string.Join(", ",result)} ");
                }
            }
            else if (textile.Count>0)
            {
                List<int> result = new List<int>(textile);
                if (textile.Count == 1)
                {
                    Console.WriteLine($"Textiles left: {string.Join("", result)}");
                }
                else
                {
                    Console.WriteLine($"Textiles left: {string.Join(", ", result)} ");
                }

            }

        }
    }
}
