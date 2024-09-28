using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumation, double travaledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumation = fuelConsumation;
            TravaledDistance = travaledDistance;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumation { get; set; }
        public double TravaledDistance { get; set; }
       

    }

}

