using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfCountries = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < counterOfCountries; i++)
            {
                string[] info = Console.ReadLine().Split();
                string contient = info[0];
                string country = info[1];
                string town = info[2];
                if (!countries.ContainsKey(contient))
                {
                    countries[contient] = new Dictionary<string, List<string>>();
                    
                }
                if (!countries[contient].ContainsKey(country))
                {
                    countries[contient][country] = new List<string>();
                }

                countries[contient][country].Add(town);
              

            }
            foreach (var continent in countries)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> {string.Join(", ",country.Value)}");

                    Console.WriteLine();
                }
            }
        }
    }
}
