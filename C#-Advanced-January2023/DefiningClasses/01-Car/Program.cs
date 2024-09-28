using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            // TODO: define the Main() method here ...
            Car bmw = new Car();
            bmw.Make = "Bavarian";
            bmw.Model = "M6";
            bmw.Year = 2015;
            Console.WriteLine($"{bmw.Make},{bmw.Model},{bmw.Year}");
                
        }
    }
}


