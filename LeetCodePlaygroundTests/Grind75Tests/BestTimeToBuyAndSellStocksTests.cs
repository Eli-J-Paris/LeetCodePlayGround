using LeetCodePlayGround.Grind75;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.Grind75Tests
{
    public class BestTimeToBuyAndSellStocksTests
    {
        [Fact]
        public void FindBestBuyAndSell_Returns_MaxProfit_When_Profit_Is_Possible()
        {
            // Arrange
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int expectedProfit = 5; // Expected profit: Buy at 1 and sell at 6

            // Act
            int actualProfit = BestTimeToBuyAndSellStocks.FindBestBuyAndSell(prices);

            // Assert
            Assert.Equal(expectedProfit, actualProfit);
        }

        [Fact]
        public void FindBestBuyAndSell_Returns_0_When_No_Profit_Is_Possible()
        {
            // Arrange
            int[] prices = { 7, 6, 4, 3, 1 };
            int expectedProfit = 0; // No profit possible

            // Act
            int actualProfit = BestTimeToBuyAndSellStocks.FindBestBuyAndSell(prices);

            // Assert
            Assert.Equal(expectedProfit, actualProfit);
        }

        [Fact]
        public void FindBestBuyAndSell_Returns_MaxProfit_When_All_Increasing_Prices()
        {
            // Arrange
            int[] prices = { 1, 2, 3, 4, 5 };
            int expectedProfit = 4; // Buy at 1 and sell at 5

            // Act
            int actualProfit = BestTimeToBuyAndSellStocks.FindBestBuyAndSell(prices);

            // Assert
            Assert.Equal(expectedProfit, actualProfit);
        }

        [Fact]
        public void FindBestBuyAndSell_Returns_MaxProfit_When_All_Decreasing_Prices()
        {
            // Arrange
            int[] prices = { 5, 4, 3, 2, 1 };
            int expectedProfit = 0; // No profit possible

            // Act
            int actualProfit = BestTimeToBuyAndSellStocks.FindBestBuyAndSell(prices);

            // Assert
            Assert.Equal(expectedProfit, actualProfit);
        }

        [Fact]
        public void FindBestBuyAndSell_Returns_MaxProfit_When_All_Same_Prices()
        {
            // Arrange
            int[] prices = { 3, 3, 3, 3, 3 };
            int expectedProfit = 0; // No profit possible

            // Act
            int actualProfit = BestTimeToBuyAndSellStocks.FindBestBuyAndSell(prices);

            // Assert
            Assert.Equal(expectedProfit, actualProfit);
        }


    }
}
