using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class CarGo
    {
        private string type;
        private int weight;

        public CarGo(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type { get; set; }
        public int Weight { get; set; }
    }
}
