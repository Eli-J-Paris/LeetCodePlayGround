using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class HighestAndLowestTests
    {
        [Fact]
        public static void HighAndLow_ReturnsBothTheHighestAndLowestNumber_FromAString_InorderFromHighToLow()
        {
            string nums = "4 5 2 1";
            string expected = "5 1";

            string result = HighestAndLowest.HighAndLow(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void HighAndLow_ReturnsBothTheHighestAndLowestNumber_FromAString_InorderFromHighToLow_2()
        {
            string nums = "-3 76 3 2 89";
            string expected = "89 -3";

            string result = HighestAndLowest.HighAndLow(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void HighAndLow_ReturnsBothTheHighestAndLowestNumber_FromAString_WhenStringContainsOneCharacter()
        {
            string nums = "1";
            string expected = "1 1";

            string result = HighestAndLowest.HighAndLow(nums);

            Assert.Equal(expected, result);
        }
    }
}
