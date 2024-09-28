using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mealsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] caloriesPerDay = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<string> meals = new Queue<string>(mealsInput);
            Stack<int> dailyCalories = new Stack<int>(caloriesPerDay);

            int mealCount = meals.Count;

            

            while (meals.Count != 0 && dailyCalories.Count != 0)
            {

                int currentDailyCalories = dailyCalories.Peek();
                int currentMealCalories = 0;



                while (true)
                {
                    if (dailyCalories.Count == 0)
                    {
                        break;
                    }
                    if (meals.Count == 0)
                    {
                        break;
                    }
                    string currentMeal = meals.Dequeue();

                    switch (currentMeal)
                    {
                        case "salad":
                            currentMealCalories = 350;
                            break;
                        case "soup":
                            currentMealCalories = 490;
                            break;
                        case "pasta":
                            currentMealCalories = 680;
                            break;
                        case "steak":
                            currentMealCalories = 790;
                            break;
                        default:
                            currentMealCalories = 0;
                            break;
                    }

                    currentDailyCalories -= currentMealCalories;

                    if (currentDailyCalories == 0)
                    {
                        dailyCalories.Pop();
                    }
                    else if (currentDailyCalories < 0)
                    {
                        int diff = Math.Abs( currentDailyCalories);
                        dailyCalories.Pop();
                        if (dailyCalories.Count>0)
                        {

                        currentDailyCalories = dailyCalories.Pop();
                        currentDailyCalories -= diff;
                        dailyCalories.Push(currentDailyCalories);
                        }
                    }


                }


            }
            int resultCount = Math.Abs(meals.Count - mealCount);

            if (meals.Count > 0)
            {
                Console.WriteLine($"John ate enough, he had {resultCount} meals.");
                List<string> result = new List<string>(meals);
                if (meals.Count > 1)
                {
                    Console.WriteLine($"Meals left: {string.Join(", ", result)}.");
                }
                else
                {
                    Console.WriteLine($"Meals left: {meals.Dequeue()}.");
                }


            }
            else
            {
                Console.WriteLine($"John had {resultCount} meals.");
                List<int> result = new List<int>(dailyCalories);
                if (dailyCalories.Count > 1)
                {
                    Console.WriteLine($"For the next few days, he can eat {string.Join(", ", result)} calories.");
                }
                else
                {
                    Console.WriteLine($"For the next few days, he can eat {dailyCalories.Pop()} calories.");
                }
            }
        }
    }
}
