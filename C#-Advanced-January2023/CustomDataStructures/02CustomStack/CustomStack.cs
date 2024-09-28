using System;
using System.Collections.Generic;
using System.Text;

namespace _02CustomStack
{
    class CustomStack
    {
        private const int InitialCpacity = 4;

        private int[] items = new int[InitialCpacity];
        public int Count { get; private set; }

        public void Push(int element)
        {
            
            if (Count == items.Length)
            {
                Resize();
            }
            items[Count] = element;
            Count++;
        }
        public int Pop()
        {
            Count--;
            return items[Count ];
        }
        public int Peek()
        {
            return items[Count-1];
        }
        public void ForEach(Action<object>action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }
        private void Resize()
        {
            int[] copy = new int[Count * 2];
            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
