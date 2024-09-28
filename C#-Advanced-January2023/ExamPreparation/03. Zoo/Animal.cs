using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
     public class Animal
    {
        public Animal(string species, string diet, double weight, double lenght)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Lenght = lenght;
        }

        public string Species { get; set; }
        public string Diet { get; set; }
        public double Weight { get; set; }
        public double Lenght { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The {Species} is a {Diet} and weighs {Weight} kg.");
            return sb.ToString().Trim();
        }
    }
}
