using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class InvertValuesTests
    {
        [Fact]
        public static void ArrayInversion_InvertsAllPositiveIntsToNegative()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] expected = { -1, -2, -3, -4, -5 };

            int[] result = InvertValues.ArrayInversion(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void ArrayInversion_InvertsAllNegativeIntsToPoistive()
        {
            int[] nums = { -1, -2, -3, -4, -5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            
            int[] result = InvertValues.ArrayInversion(nums);

            Assert.Equal(expected, result);
        }
        [Fact]
        public static void ArrayInversion_InvertsMixedPostive_and_NegativeInts()
        {
            int[] nums = { 1, -2, -3, 4, 5 };
            int[] expected = { -1, 2, 3, -4, -5 };

            int[] result = InvertValues.ArrayInversion(nums);

            Assert.Equal(expected, result);
        }


    }
}
