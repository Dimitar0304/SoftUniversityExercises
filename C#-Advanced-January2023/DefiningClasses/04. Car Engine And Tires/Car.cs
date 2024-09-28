using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make,string model,int year):this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
          
        }
        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption):this()
        {
            
            
            this. FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption,Engine engine,Tire[] tires):this(make, model, year, fuelConsumption, fuelQuantity)
        {
            Engine = engine;
            Tires = tires;
        }
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public double FuelQuantity { get; set; }
         public double FuelConsumption { get; set; }
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public void WhoIAm()
        {
            StringBuilder sb = new StringBuilder();
           sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:F2}");
            sb.Append($"{this.Engine.Hp} and {this.Engine.CubicCapacity}");
            foreach (var item in this.Tires)
            {
                sb.AppendLine($"{item.Year} - {item.Pressure}");
            }
            Console.WriteLine(sb);
        }

    }
}
