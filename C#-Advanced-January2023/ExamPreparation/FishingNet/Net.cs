using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fishes = new List<Fish>();
        }

        public List<Fish> Fishes { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Fishes.Count; } }

        public string AddFish(Fish fish)
        {
            if (fish.Lenght<=0||fish.Weigth<=0)
            {
                return "Invalid fish.";

            }
            if (fish.FishType==null||fish.FishType==string.Empty)
            {
                return "Invalid fish.";
            }
            if (Capacity==Count)
            {
                return "Fishing net is full.";
            }
            Fishes.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
            bool isExist = false;
            for (int i = 0; i < Fishes.Count; i++)
            {
                if (Fishes[i].Weigth==weight)
                {
                    Fishes.RemoveAt(i);
                    isExist = true;
                }
            }
            return isExist;
        }

        public Fish GetFish(string fishtype)
        {
            return Fishes.FirstOrDefault(f => f.FishType == fishtype);
        }

        public Fish GetBiggestFish()
        {
            Fish longestFish = new Fish(" ", 1, 1);

            for (int i = 0; i < Fishes.Count; i++)
            {
                if (Fishes[i].Lenght>longestFish.Lenght)
                {
                    longestFish = Fishes[i];
                }
            }
            return longestFish;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}");
            foreach (var item in Fishes)
            {
                sb.AppendLine($"{item}");
            }
            return sb.ToString().Trim();
        }
    }
}
