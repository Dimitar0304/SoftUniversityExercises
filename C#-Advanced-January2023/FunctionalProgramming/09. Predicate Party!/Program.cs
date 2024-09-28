using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

         

            string command = string.Empty;
            while ((command=Console.ReadLine())!="Party!")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if (action=="Remove")
                {
                    guests.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    List<string> guestToDouble = guests.FindAll(GetPredicate(filter,value));

                    foreach (var guest in guestToDouble)
                    {
                        int index = guests.FindIndex(p => p == guest);
                        guests.Insert(index, guest);
                    }

                }
            }
            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ",guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return p => p.StartsWith(value);
                case "EndsWith":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                    
                default:
                    return default;
                   
            }
        }
    }
}
