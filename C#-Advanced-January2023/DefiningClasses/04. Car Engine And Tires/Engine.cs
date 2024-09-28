using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Engine
    {
        private int hp;
        private double cubicCapacity;
        public Engine(int hp,double cubicCapacity)
        {
            Hp = hp;
            CubicCapacity = cubicCapacity;
        }

        public int Hp { get; set; }
        public double CubicCapacity { get; set; }
    }
}
