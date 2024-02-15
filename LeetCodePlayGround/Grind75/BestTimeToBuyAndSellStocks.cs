using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.*/

namespace LeetCodePlayGround.Grind75
{
    public class BestTimeToBuyAndSellStocks
    {
        //8,2,5,4,7,3,1
        public static int FindBestBuyAndSell(int[] prices)
        {
            //this variable will hold the potential best sell time I.E max value
            int bestSell = 0;
            //this variable will hold the potential best but time I.E. Min value which starts out at index 0 of the prices array
            int bestBuy = prices[0];

            // loop over the entire array starting at the second position: i = 1; 
            for (int i = 1; i < prices.Length; i++)
            {
                // comapres if the index is lower than the best buy and if so set the best buy variable to the new price.
                if (prices[i] < bestBuy)
                {
                    bestBuy = prices[i];
                }
                // if the current index - the best buy variable is greater than the current best sell variable I.E more profit. Set the new best sell = to price[i - the current best buy
                else if (prices[i] - bestBuy > bestSell)
                {
                    bestSell = prices[i] - bestBuy;
                }
            }
            //return int
            return bestSell;

        }
    }
}
