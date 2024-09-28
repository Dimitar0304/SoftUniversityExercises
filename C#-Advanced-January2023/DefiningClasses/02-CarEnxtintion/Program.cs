using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "bavarian";
            car.Model = "M5";
            car.Year = 2016;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            car.WhoIAm();
        }
    }
}
