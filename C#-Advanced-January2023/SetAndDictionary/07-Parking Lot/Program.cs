using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> carNumbers = new HashSet<string>();
            while (command!="END")
            {
                string[] info = command.Split(',',StringSplitOptions.RemoveEmptyEntries);
                string direction = info[0];
                string carNumber = info[1];
                
                if (direction=="IN")
                {
                    carNumbers.Add(carNumber);
                }
                if (direction =="OUT")
                {
                    carNumbers.Remove(carNumber);
                }
                command = Console.ReadLine();
            }
            if (carNumbers.Count>0)
            {
                foreach (var item in carNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
