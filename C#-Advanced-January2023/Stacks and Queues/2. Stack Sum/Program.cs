using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List < int > list= Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(list);

            string command = Console.ReadLine().ToLower();
            while (command!="end")
            {
                string[] commandInfo = command.Split();
                if (commandInfo[0]=="remove")
                {
                    int n = int.Parse(commandInfo[1]);
                    if (n<=stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                   
                }
                if (commandInfo[0]=="add")
                {
                    int n1 = int.Parse(commandInfo[1]);
                    int n2 = int.Parse(commandInfo[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                    
                }


                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
