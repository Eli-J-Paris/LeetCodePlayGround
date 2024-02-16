using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class FindSmallestIntTests
    {

        [Fact]
        public void FindSmallestIntInArray_ReturnsSmallestInt()
        {
            int[] nums = [4, 7, 23, 7, 2, 9, 3 ];
            int expectedValue = 2;

            int result = FindSmallestInt.FindSmallestIntInArry(nums);

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void FindSmallestIntInArray_ReturnsSmallestInt_2()
        {
            int[] nums = [0,0,0,0];
            int expectedValue = 0;

            int result = FindSmallestInt.FindSmallestIntInArry(nums);

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void FindSmallestIntInArray_ReturnsSmallestInt_3()
        {
            int[] nums = [1,2];
            int expectedValue = 1;

            int result = FindSmallestInt.FindSmallestIntInArry(nums);

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void FindSmallestIntInArray_ReturnsSmallestInt_4()
        {
            int[] nums = [1];
            int expectedValue = 1;

            int result = FindSmallestInt.FindSmallestIntInArry(nums);

            Assert.Equal(expectedValue, result);
        }
    }
}
