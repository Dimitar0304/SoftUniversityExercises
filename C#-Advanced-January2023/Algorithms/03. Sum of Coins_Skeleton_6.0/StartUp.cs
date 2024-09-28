namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());
            var amountOfCoins = ChooseCoins(coins, target);

            Console.WriteLine($"Number of coins to take: {amountOfCoins.Values.Sum()}");
            foreach (var item in amountOfCoins)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            coins = coins.OrderByDescending(x=>x).ToList();
            Dictionary<int, int> result = new Dictionary<int, int>();
            int currentSum = 0;
            while (currentSum < targetSum)
            {


                foreach (int coin in coins)
                {
                    if (currentSum + coin <= targetSum)
                    {
                        if (!result.ContainsKey(coin))
                        {
                            result.Add(coin, 0);
                        }
                        result[coin]++;
                        currentSum += coin;
                        break;
                    }
                }
            }
            return result;
        }
    }
}