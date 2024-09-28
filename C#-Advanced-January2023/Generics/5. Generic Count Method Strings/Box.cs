using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T :IComparable<T>
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
        public int Count(T value)
        {
            int count = 0;
            foreach (var item in this.Items)
            {
                if (value.CompareTo(item)==-1)
                {
                    count++;
                }
            }
            return count;
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
