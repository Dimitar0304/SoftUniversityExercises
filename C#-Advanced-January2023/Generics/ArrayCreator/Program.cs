using System;

namespace GenericArrayCreator
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            string[] dimitrichko = ArrayCreator<string>.Create(5, "dimitrichko");

            Console.WriteLine(string.Join(",",dimitrichko));
        }
    }
}
