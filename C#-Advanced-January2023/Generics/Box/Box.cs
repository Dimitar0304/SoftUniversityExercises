using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
     public class Box<T>
    {
        private List<T> collection ;
        private int count;
        public Box()
        {
            collection = new List<T>();
        }
        public int Count { get{ return this.count; } }
        public void Add(T element)
        {
            count++;
            collection.Add(element);
        }
        public T Remove()
        {
            count--;
            T removedElement = collection[collection.Count - 1];
            collection.Remove(removedElement);

            return removedElement;
        }
    }
}
