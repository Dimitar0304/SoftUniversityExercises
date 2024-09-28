using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> drinksCout = new Dictionary<string, int>();
            int[] coffieeValues = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] milkValues = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> coffee = new Queue<int>(coffieeValues);
            Stack<int> milk = new Stack<int>(milkValues);

            while (milk.Count!=0&&coffee.Count!=0)
            {
                int currentCoffee = coffee.Peek();
                int currentMilk = milk.Peek();
                int sum = currentCoffee + currentMilk;

                if (sum==50)
                {
                    //Cortado
                    coffee.Dequeue();
                    milk.Pop();
                    if (!drinksCout.ContainsKey("Cortado"))
                    {
                        drinksCout.Add("Cortado", 0);
                    }
                    drinksCout["Cortado"]++;
                }
                else if (sum ==75)
                {
                    //Espresso
                    coffee.Dequeue();
                    milk.Pop();
                    if (!drinksCout.ContainsKey("Espresso"))
                    {
                        drinksCout.Add("Espresso", 0);
                    }
                    drinksCout["Espresso"]++;
                }
                else if (sum ==100)
                {
                    //Capuccino
                    coffee.Dequeue();
                    milk.Pop();
                    if (!drinksCout.ContainsKey("Capuccino"))
                    {
                        drinksCout.Add("Capuccino", 0);
                    }
                    drinksCout["Capuccino"]++;
                }
                else if (sum ==150)
                {
                    //Americano
                    coffee.Dequeue();
                    milk.Pop();
                    if (!drinksCout.ContainsKey("Americano"))
                    {
                        drinksCout.Add("Americano", 0);
                    }
                    drinksCout["Americano"]++;
                }
                else if (sum==200)
                {
                    //Latte
                    coffee.Dequeue();
                    milk.Pop();
                    if (!drinksCout.ContainsKey("Latte"))
                    {
                        drinksCout.Add("Latte", 0);
                    }
                    drinksCout["Latte"]++;
                }
                else
                {
                    //is not one of these
                    coffee.Dequeue();
                    int oldMilkValue = milk.Pop();
                    oldMilkValue -= 5;
                    milk.Push(oldMilkValue);
                }



            }

            if (coffee.Count==0&&milk.Count==0)
            {
                Console.WriteLine($"Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine($"Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            if (coffee.Count > 0)
            {
                Console.Write($"Coffee left: ");
                if (coffee.Count == 1)
                {
                    Console.Write($"{coffee.Dequeue()}");
                    Console.WriteLine();
                }
                else
                {


                    while (coffee.Count != 0)
                    {
                        Console.Write($"{coffee.Dequeue()}, ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Coffee left: none");
            }





            if (milk.Count>0)
            {
                Console.Write($"Milk left: ");
                if (milk.Count == 1)
                {
                    Console.Write($"{milk.Pop()}");
                    Console.WriteLine();
                }
                else
                {


                    while (milk.Count != 0)
                    {
                        Console.Write($"{milk.Pop()}, ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Milk left: none");
            }
          
            

            foreach (var item in drinksCout.OrderBy(i=>i.Value).ThenByDescending(i=>i))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
