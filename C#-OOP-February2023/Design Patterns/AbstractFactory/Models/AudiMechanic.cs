﻿using AbstractFactory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class AudiMechanic : IMechanic
    {
        public void GetDescription()
        {
            Console.WriteLine("Im only make audi mark");
        }
    }
}
