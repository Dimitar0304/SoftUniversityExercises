﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Foods;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            if (type=="Vegetable")
            {
                return new Vegetable(quantity);
            }
            else if (type=="Fruit")
            {
                return new Fruit(quantity);
            }
            else if (type=="Meat")
            {
                return new Meat(quantity);
            }
            else if (type=="Seeds")
            {
                return new Seeds(quantity);
            }
            else
            {
                throw new ArgumentException("Invalid Food type");
            }
        }
    }
}
