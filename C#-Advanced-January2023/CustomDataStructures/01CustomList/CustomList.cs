using System;
using System.Collections.Generic;
using System.Text;

namespace _01CustomList
{
    class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items = new int[InitialCapacity];

        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }


        public void Add(int element)
        {
            if (items.Length==Count)
            {
                Resize();
            }
            items[Count] = element;
            Count++;
        }
        public int RemoveAt(int index)
        {
            if (IndexCheck(index) == true)
            {


                Count--;
                if (Count <= this.items.Length / 4)
                {
                    this.Shrink();
                }

                return items[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException();

            }
           
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i]==element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstElement,int secondElement)
        {
            int indexOFFirstElement = 0;
            int indexOfSecondElement = 0;
            for (int i = 0; i < Count; i++)
            {
                if (items[i]==firstElement)
                {
                    indexOFFirstElement = i;
                }
                if (items[i]==secondElement)
                {
                    indexOfSecondElement = i;
                }
            }
            int joker = firstElement;
            items[indexOFFirstElement] = secondElement;
            items[indexOfSecondElement] = joker;
        }
        public void Insert(int index, int element)
        {
            if (IndexCheck(index)==true)
            {
                Count++;
                if (Count==items.Length)
                {
                    Resize();
                }
               
                Shift(index);
                items[index] = element;
            }
        }

        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
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
        private void Shift(int index)
        {
            for (int i = Count ; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }
        private bool IndexCheck(int index)
        {
            if (index<0)
            {
                return false;
            }
            if (index>Count)
            {
                return false;
            }
            return true;
        }
    }
}
