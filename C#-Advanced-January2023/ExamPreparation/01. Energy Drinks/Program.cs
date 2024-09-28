using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Energy_Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            //we recive sequance of coffeine
            //then recive sequance of energy drinks

            //max coffein per day is 300mg

            //we multiply last of coffein by first of drinks
            //if  the result is < than the maximum we remove coffeine and drink from sequance
            //else we remove coffeine from sequance and add drink at the end of sequance also le decrease from current coffeineDose 30
            //we end program when one of these sequances are become to 0 elements. and print.


            //if it have already energy drinks
            //	"Drinks left: { remaining drinks separated by ", " }"
            //if he drunk all energy drinks 
            //	"At least Stamat wasn't exceeding the maximum caffeine."

            //and on the next line print 
            //o	"Stamat is going to sleep with { current caffeine } mg caffeine."
            int[] cofeinInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] energyDrinksInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int currenCoffeine = 0;
            

            Stack<int> coffein = new Stack<int>(cofeinInput);
            Queue<int> energyDrinks = new Queue<int>(energyDrinksInput);

            while (coffein.Count!=0&&energyDrinks.Count!=0)
            {
                int coffeine = coffein.Pop();
                int currentEnergyDrink = energyDrinks.Dequeue();
                int currentSum = coffeine * currentEnergyDrink;

                if (currentSum+currenCoffeine<=300)
                {
                    //remove both of sequances
                    currenCoffeine += currentSum;
                }
                else
                {
                    energyDrinks.Enqueue(currentEnergyDrink);
                    if (currenCoffeine-30!>=0)
                    {
                        currenCoffeine -= 30;
                    }
                   
                }
            }


            if (energyDrinks.Count>0)
            {
                int[] leftDrinks = energyDrinks.ToArray();
                Console.WriteLine($"Drinks left: {string.Join(" ,",leftDrinks)}");
            }
            else if(energyDrinks.Count==0)
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }
            Console.WriteLine($"Stamat is going to sleep with {currenCoffeine} mg caffeine.");
        }
    }
}
