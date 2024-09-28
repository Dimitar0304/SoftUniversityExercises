using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Bakery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Barkery = new Dictionary<string, int>();
            double[] waterNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            double[] flourNumbers = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(double.Parse).ToArray();

            Queue<double> waters = new Queue<double>(waterNumbers);
            Stack<double> flour = new Stack<double>(flourNumbers);

            while (waters.Count!=0&&flour.Count!=0)
            {
                double currentWater = waters.Dequeue();
               double currentFlour = flour.Pop();

                double sum = currentWater + currentFlour;
                double precantage = (currentWater * 100) / sum;

                if (precantage==50)
                {
                    if (!Barkery.ContainsKey("Croissant"))
                    {

                    Barkery.Add("Croissant", 0);
                    }
                    Barkery["Croissant"]++;
                }
                else if (precantage==40)
                {
                    if (!Barkery.ContainsKey("Muffin"))
                    {
                        Barkery.Add("Muffin", 0);
                    }
                    Barkery["Muffin"]++;
                }
                else if (precantage==30)
                {
                    if (!Barkery.ContainsKey("Baguette"))
                    {
                        Barkery.Add("Baguette", 0);
                    }
                    Barkery["Baguette"]++;
                }
                else if (precantage==20)
                {
                    if (!Barkery.ContainsKey("Bagel"))
                    {
                        Barkery.Add("Bagel", 0);
                    }
                    Barkery["Bagel"]++;
                }
                else
                {
                    double itemtoAddInFlour = Math.Abs(currentWater - currentFlour);
                    flour.Push(itemtoAddInFlour);
                    if (!Barkery.ContainsKey("Croissant"))
                    {

                        Barkery.Add("Croissant", 0);
                    }
                    Barkery["Croissant"]++;
                }


            }

            foreach (var item in Barkery.OrderByDescending(i=>i.Value).ThenBy(i=>i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            if (waters.Count>0)
            {
                List<double> result = new List<double>(waters);
                if (result.Count==1)
                {
                    Console.WriteLine($"Water left: {string.Join("",result)}");
                }
                else
                {
                    Console.WriteLine($"Water left: {string.Join(", ",result)}");
                }
            }
            else
            {
                Console.WriteLine("Water left: None");
            }


            if (flour.Count > 0)
            {
                List<double> result = new List<double>(flour);
                if (result.Count == 1)
                {
                    Console.WriteLine($"Flour left: {string.Join("", result)}");
                }
                else
                {
                    Console.WriteLine($"Flour left: {string.Join(", ", result)}");
                }
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
