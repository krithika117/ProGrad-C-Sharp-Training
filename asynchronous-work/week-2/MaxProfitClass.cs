using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_hands_on
{
    internal class MaxProfitClass
    {
        public static int MaxProfit(int[] prices)
        {
            int buy = prices[0]; // [7, 1, 5, 3, 6, 4]
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (buy > prices[i])
                {
                    buy = prices[i];
                }
                else
                {
                    profit = Math.Max(profit, prices[i] - buy);
                }
            }
            return profit;
        }
        public static void Main(string[] args) {
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(arr));
        }
    }
}
