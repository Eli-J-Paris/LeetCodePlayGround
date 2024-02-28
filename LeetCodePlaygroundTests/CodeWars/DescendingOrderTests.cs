using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class DescendingOrderTests
    {
        [Fact]
        public static void OrderDescending_ReordersIntIntoDescendingOrder()
        {
            int num = 12345;
            int expected = 54321;

            int result = DescendingOrder.OrderDescending(num);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void OrderDescending_ReordersIntIntoDescendingOrder_2()
        {
            int num = 33617;
            int expected = 76331;

            int result = DescendingOrder.OrderDescending(num);

            Assert.Equal(expected, result);
        }

    }
}
