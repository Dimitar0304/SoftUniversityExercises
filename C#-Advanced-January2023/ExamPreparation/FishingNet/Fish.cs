using System;
using System.Collections.Generic;
using System.Text;

namespace FishingNet
{
    public class Fish
    {
        public Fish(string fishType, double lenght, double weigth)
        {
            FishType = fishType;
            Lenght = lenght;
            Weigth = weigth;
        }

        public string FishType { get; set; }
        public double Lenght { get; set; }
        public double Weigth { get; set; }

        public override string ToString()
        {
            return $"There is a {FishType}, {Lenght} cm. long, and {Weigth} gr. in weight.";
        }
    }
}
