using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zoo
{
    public class _Zoo
    {
        public _Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        public List<Animal> Animals { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public string AddAnimal(Animal animal)
        {
            if (animal.Diet!= "herbivore"&& animal.Diet!= "carnivore")
            {
                return"Invalid animal diet.";
            }
            if (Capacity==Animals.Count)
            {
                return "The zoo is full.";
            }
            if (animal.Species==null||animal.Species==string.Empty)
            {
                return "Invalid animal species.";
            }
            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int counter = 0;
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Species==species)
                {
                    
                    Animals.RemoveAt(i);
                    i--;
                    counter++;
                }
            }
            return counter;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> result = new List<Animal>();
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Diet==diet)
                {
                    result.Add(Animals[i]);
                }
            }
            if (result.Count==0)
            {
                return default;
            }
            return result;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            return Animals.FirstOrDefault(a => a.Weight == weight);
        }

        public string GetAnimalCountByLength(double minimumLenght,double maximumLenght)
        {
            int counter = 0;
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Lenght>=minimumLenght&&Animals[i].Lenght<=maximumLenght)
                {
                    counter++;
                }
            }
            return $"There are {counter} animals with a length between {minimumLenght} and {maximumLenght} meters.";
        }
    }
}
