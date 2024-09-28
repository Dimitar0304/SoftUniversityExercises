using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carGoCatalogue = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = commandInfo[0];
                int engineSpeed = int.Parse(commandInfo[1]);
                int enginePower = int.Parse(commandInfo[2]);
                int carGoWeight = int.Parse(commandInfo[3]);
                string carGoType = commandInfo[4];

                double tire1Pressure = double.Parse(commandInfo[5]);
                int tire1Age = int.Parse(commandInfo[6]);

                double tire2Pressure = double.Parse(commandInfo[7]);
                int tire2Age = int.Parse(commandInfo[8]);

                double tire3Pressure = double.Parse(commandInfo[9]);
                int tire3Age = int.Parse(commandInfo[10]);

                double tire4Pressure = double.Parse(commandInfo[11]);
                int tire4Age = int.Parse(commandInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                CarGo carGo = new CarGo(carGoType, carGoWeight);
                List<Tire> tires = new List<Tire>();
                Tire tire1 = new Tire(tire1Pressure, tire1Age);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);
                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);

                Car car = new Car(model, engine, carGo, tires);

                carGoCatalogue.Add(car);
            }
            string carGoPRint = Console.ReadLine();

            if (carGoPRint== "fragile")
            {
                foreach (var car in carGoCatalogue.Where(c=>c.CarGo.Type== "fragile"&&c.Tires.Any(t=>t.Pressure<1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (carGoPRint== "flammable")
            {
                foreach (var car in carGoCatalogue.Where(c => c.CarGo.Type == carGoPRint&&c.Engine.Power>250))
                {
                    Console.WriteLine(car.Model);
                }
            }
           
        }
    }
}
