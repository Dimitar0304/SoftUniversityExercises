using System;
using System.Collections.Generic;
using System.Linq;
namespace _8._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string command = Console.ReadLine();
            while (command!="PARTY")
            {
                if (char.IsDigit(command[0]))
                {
                    vipGuests.Add(command);
                }
                else
                {
                    regularGuests.Add(command);
                }
                command = Console.ReadLine();
            }
            string guestToCome = Console.ReadLine();
            while (guestToCome!="END")
            {

                    vipGuests.Remove(guestToCome);
        
               
                    regularGuests.Remove(guestToCome);
            
                guestToCome = Console.ReadLine();
            }

            int guestWhosNotCome = 0;
            if (vipGuests.Count>0)
            {
                guestWhosNotCome = vipGuests.Count + regularGuests.Count;
                Console.WriteLine(guestWhosNotCome);
                foreach (var item in vipGuests)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in regularGuests)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                guestWhosNotCome = vipGuests.Count + regularGuests.Count;
                Console.WriteLine(guestWhosNotCome);
                foreach (var item in regularGuests)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
