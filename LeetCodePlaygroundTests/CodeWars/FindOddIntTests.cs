using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class FindOddIntTests
    {
        [Fact]
        public static void FindInt_FindsTheOddOccuranceOfAnIntInAnArray()
        {
            int[] nums = [1, 2, 1];
            int expected = 2;

            int result = FindOddInt.FindInt(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void FindInt_FindsTheOddOccuranceOfAnIntInAnArray_2()
        {
            int[] nums = [1,2,1,2,4,4,6,6,2];
            int expected = 2;

            int result = FindOddInt.FindInt(nums);

            Assert.Equal(expected, result);
        }

    }
}
