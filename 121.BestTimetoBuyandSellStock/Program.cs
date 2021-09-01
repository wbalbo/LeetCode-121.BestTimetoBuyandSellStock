using System;
using System.Collections.Generic;
using System.Linq;

namespace _121.BestTimetoBuyandSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the values as you wish. Rule: number has to be > 0
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int profit = MaxProfit(prices);

            Console.WriteLine("Total Profit: " + profit);
            Console.ReadKey();
        }

        private static int MaxProfit(int[] prices)
        {
            if (prices.Length == 1)
                return 0;

            int buyValue = 0;
            int sellValue = 1;
            int maxProfit = 0;

            while (sellValue < prices.Length)
            {
                if (prices[buyValue] < prices[sellValue])
                {
                    int profit = prices[sellValue] - prices[buyValue];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                    buyValue = sellValue; //Sets the buyValue to the next minimum, which is the sellValue

                sellValue += 1; //to keep iterating until while condition are met
            }

            return maxProfit;
        }
    }
}
