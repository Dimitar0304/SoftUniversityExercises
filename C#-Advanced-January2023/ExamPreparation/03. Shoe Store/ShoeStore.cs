using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity, List<Shoe> shoes)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = shoes;
        }
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes = new List<Shoe>();

        public void GetterCount(List<Shoe> shoes)
        {
            Console.WriteLine(shoes.Count);
        }
        public string AddShoe(Shoe shoe)
        {
            if (this.StorageCapacity>this.Shoes.Count)
            {

                this.Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }

            
            return $"No more space in the storage room.";




        }
        public int RemoveShoes(string material)
        {
            
            int counter = 0;
            foreach (var shoe in this.Shoes)
            {
                if (shoe.Material == material)
                {
                    this.Shoes.Remove(shoe);
                    counter++;
                }


            }
            return counter;
        }
        public List<Shoe> GetShoesByType(string type)
        {
            //List<Shoe> shoes = new List<Shoe>(this.Shoes);
            List<Shoe> result = new List<Shoe>();

            foreach (var shoe in this.Shoes)
            {
                if (shoe.Type.ToLower() == type.ToLower())
                {
                    result.Add(shoe);
                }

            }
            return result;
        }
        public Shoe GetShoeBySize(double size)
        {
            //List<Shoe> shoes = new List<Shoe>(this.Shoes);
            foreach (var item in this.Shoes.Where(s => s.Size == size))
            {
                return item;
            }
            return null;
        }
        public string StockList(double size, string type)
        {
            //List<Shoe> shoes = new List<Shoe>(this.Shoes);
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            foreach (var shoe in this.Shoes)
            {
                if (shoe.Size == size && shoe.Type == type)
                {
                    counter++;
                    sb.AppendLine($"{shoe.ToString()}");
                }

            }
            if (counter == 0)
            {
                sb.AppendLine("No matches found!");
            }

            return sb.ToString().Trim();
        }
    }
}
