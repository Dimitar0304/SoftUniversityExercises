using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> locationTiles = new Dictionary<string, int>();
            int[] whiteInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] greyInput = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();
            Stack<int> whiteTiles = new Stack<int>(whiteInput);
            Queue<int> greyTiles = new Queue<int>(greyInput);

            while (whiteTiles.Count!=0&&greyTiles.Count!=0)
            {
                int currentWhite = whiteTiles.Peek();
                int currentGrey = greyTiles.Peek();

                if (currentWhite!=currentGrey)
                {
                    currentWhite = currentWhite / 2;
                    whiteTiles.Pop();
                    whiteTiles.Push(currentWhite);

                    greyTiles.Dequeue();
                    greyTiles.Enqueue(currentGrey);
                }
                else
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                    int sum = currentWhite + currentGrey;
                    if (sum== 40)
                    {
                        if (!locationTiles.ContainsKey("Sink"))
                        {
                            locationTiles.Add("Sink", 0);
                        }
                        locationTiles["Sink"]++;
                    }
                    else if (sum ==50)
                    {
                        if (!locationTiles.ContainsKey("Oven"))
                        {
                            locationTiles.Add("Oven", 0);
                        }
                        locationTiles["Oven"]++;
                    }
                    else if (sum==60)
                    {
                        //Countertop

                        if (!locationTiles.ContainsKey("Countertop"))
                        {
                            locationTiles.Add("Countertop", 0);
                        }
                        locationTiles["Countertop"]++;
                    }
                    else if (sum==70)
                    {
                        if (!locationTiles.ContainsKey("Wall"))
                        {
                            locationTiles.Add("Wall", 0);
                        }
                        locationTiles["Wall"]++;
                    }
                    else
                    {
                        if (!locationTiles.ContainsKey("Floor"))
                        {
                            locationTiles.Add("Floor", 0);
                        }
                        locationTiles["Floor"]++;
                    }
                }
            }

            if (whiteTiles.Count==0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                if (whiteTiles.Count==1)
                {
                    Console.WriteLine($"White tiles left: {whiteTiles.Pop()}");
                }
                else
                {
                    Console.Write("White tiles left: ");
                    while (whiteTiles.Count!=1)
                    {
                        Console.Write($"{whiteTiles.Pop()}, ");
                    }
                    Console.Write($"{whiteTiles.Pop()}");
                    Console.WriteLine();
                }
               
                
            }

            if (greyTiles.Count==0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                if (greyTiles.Count==1)
                {
                    Console.WriteLine($"Grey tiles left: {greyTiles.Dequeue()}");
                }
                else
                {
                    Console.Write("Grey tiles left: ");
                    while (greyTiles.Count!=1)
                    {
                        Console.Write($"{greyTiles.Dequeue()}, ");
                    }
                    Console.Write($"{greyTiles.Dequeue()}");
                    Console.WriteLine();
                }
            }

            foreach (var item in locationTiles.OrderByDescending(i=>i.Value).ThenBy(i=>i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
