using System;

namespace _01CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            list.RemoveAt(7);
            list.RemoveAt(6);
            list.RemoveAt(5);
            list.RemoveAt(4);
            list.RemoveAt(3);
             list.RemoveAt(2);

            
            
            Console.WriteLine(list.Contains(1));
            Console.WriteLine(list.Contains(99));

            list.Add(100);

            list.Swap(1, 100);

            list.Insert(1, 1000);
            Console.WriteLine();
        }
    }
}
