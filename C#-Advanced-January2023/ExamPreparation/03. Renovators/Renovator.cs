using System;
using System.Collections.Generic;
using System.Text;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public int Days { get; set; }
        public bool Hired { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //            "-Renovator: {name}
            //--Specialty: { type}
            //            --Rate per day: { rate}
            //            BGN"
            sb.AppendLine($"-Renovator: {this.Name}");
            sb.AppendLine($"--Specialty: {Type}");
            sb.AppendLine($"--Rate per day: {Rate} BGN");
            return sb.ToString().Trim();

        }
    }
}
