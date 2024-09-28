using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        
        
        public List<T> Items { get; set; }
        public Box()
        {
            Items = new List<T>();
        }

        public void Swap(int item1, int item2)
        {
            T temp = Items[item1];
            Items[item1] = Items[item2];
            Items[2] = temp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
