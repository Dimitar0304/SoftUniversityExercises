using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Climb_The_Peaks
{
    class Program
    {
        static void Main(string[] args)
        {
            //we recive a squance of int by daily food portions->stack
            //we recive a sequance of daily stamina-> Queue
            //we sum = dailyFood + dailyStamina and check 
            //if sum is equal or greater then peaks level we conquered it and remove from sequances these int values
            //else if sum is less alex go to sleep and come tomorow again with new values day++;
            //his mission is for seven days to climb all peaks
            //if all days expire program end and we print.

            //otuput
            //if alex climb all peaks for seven days
            //: "Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK"
            //if he not 
            //"Alex failed! He has to organize his journey better next time -> @PIRINWINS"
            //if he climbed peaks are>0 print the peaks by name
            //peaks - level is a Dictionary

            int[] sequanceOfFood = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] sequanceOfStamina = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> portionsOfFood = new Stack<int>(sequanceOfFood);
            Queue<int> dailyStamina = new Queue<int>(sequanceOfStamina);

            int daysCounterForMission = 7;

            Queue<string> peaks = new Queue<string>();
            Dictionary<string, int> PeakDificultyLevelValues = new Dictionary<string, int>();
            Queue<string> Reachedpeaks = new Queue<string>();

            PeakDificultyLevelValues.Add("Vihren", 80);
            PeakDificultyLevelValues.Add("Kutelo", 90);
            PeakDificultyLevelValues.Add("Banski Suhodol", 100);
            PeakDificultyLevelValues.Add("Polezhan", 60);
            PeakDificultyLevelValues.Add("Kamenitza", 70);
            peaks.Enqueue("Vihren");
            peaks.Enqueue("Kutelo");
            peaks.Enqueue("Banski Suhodol");
            peaks.Enqueue("Polezhan");
            peaks.Enqueue("Kamenitza");


            while (daysCounterForMission!=0&&portionsOfFood.Count!=0&&dailyStamina.Count!=0&&peaks.Count!=0)
            {
                int currentFoodSply = portionsOfFood.Pop();
                int currentStaminaValue = dailyStamina.Dequeue();
                string currentPeak = peaks.Peek();

                int currentSum = currentFoodSply + currentStaminaValue;

                if (currentSum>=PeakDificultyLevelValues[currentPeak])
                {
                    //peak is climbed for a current day;
                    Reachedpeaks.Enqueue(currentPeak);
                    peaks.Dequeue();
                }
                else 
                {
                    daysCounterForMission--;
                    //peak is not climbbed

                }
            }

            if (peaks.Count==0)
            {
                Console.WriteLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else
            {
                Console.WriteLine($"Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }

            if (Reachedpeaks.Count>0)
            {
                foreach (var item in Reachedpeaks)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

