using System;
using System.Collections.Generic;
using System.Text;

namespace _03CustomQueue
{
    class CustomQueue
    {
        private const int InitialCapacity = 4;

        private int[] items = new int[InitialCapacity];

        public int Count { get; private set; }

        public void Enqueue(int element)
        {
            if (Count == items.Length)
            {
                Resize();
            }
            items[Count] = element;
            Count++;
        }
        public int Dequeue()
        {
            int[] copy = new int[this.items.Length];
            int result = items[0];
            for (int i = 1; i < Count; i++)
            {
                copy[i - 1] = items[i];
            }
            items = copy;
            Count--;
            return result;
        }
        public int Peek()
        {
            return items[Count - 1];
        }
        public void Clear()
        {
            items = new int[InitialCapacity];
        }
        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }

        private void Resize()
        {
            int[] copy = new int[Count * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
