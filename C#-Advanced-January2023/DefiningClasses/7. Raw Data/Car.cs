using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Car
    {
        private string model;
        private Engine engine;
        private CarGo carGo;
        private Tire[] tires;


        public Car(string model, Engine engine, CarGo carGo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            CarGo = carGo;
            Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public CarGo CarGo { get; set; }
        public List<Tire> Tires = new List<Tire>();

    }
}
