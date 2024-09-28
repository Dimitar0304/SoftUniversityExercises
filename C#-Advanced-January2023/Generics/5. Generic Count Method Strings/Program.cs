using System;

namespace GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<String> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Items.Add(input);
            }
            string value = Console.ReadLine();

            Console.WriteLine(box.Count(value));
        }
    }
}
