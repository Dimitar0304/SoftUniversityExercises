using System;
using System.Collections.Generic;
using System.Linq;
namespace _4._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();
            while (command!="Revision")
            {
                string[] commandInfo = command.Split(',',StringSplitOptions.RemoveEmptyEntries);
                string shop = commandInfo[0];
                string product = commandInfo[1];
                double price = double.Parse(commandInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }
                shops[shop][product] = price;



                command = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, double>> result = new Dictionary<string, Dictionary<string, double>>();
            result = shops.OrderBy(n => n.Key).ToDictionary(s=>s.Key,s=>s.Value);

            foreach (var shop in result)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var prodict in shop.Value)
                {
                    Console.WriteLine($"Product:{prodict.Key}, Price: {prodict.Value}");
                }
            }
        }
    }
}
