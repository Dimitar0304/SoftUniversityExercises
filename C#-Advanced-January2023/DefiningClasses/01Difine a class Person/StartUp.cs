using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class StartUp
    {
        private static void Main(string[] args)
        {
            Person peter = new Person();
            {
                peter.Name = "Peter";
                peter.Age = 19;
            }
            Person dimitrichko = new Person();
            {
                dimitrichko.Name = "Dimitar";
                dimitrichko.Age = 18;
            }

            Console.WriteLine($"{peter.Name} is {peter.Age} old ");

            Console.WriteLine($"{dimitrichko.Name} is {dimitrichko.Age} old ");
        }
    }
}
