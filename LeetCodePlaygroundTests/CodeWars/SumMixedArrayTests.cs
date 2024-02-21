using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class SumMixedArrayTests
    {
        [Fact]
        public void SumMix_ReturnsSum_AllNumsInts()
        {
            object[] data = [10, 5, 2];
            int expected = 17;

            int result = SumMixedArray.SumMix(data);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SumMix_ReturnsSum_WhenMixedWithStrings()
        {
            object[] data = [10, 5, 2,"1"];
            int expected = 18;

            int result = SumMixedArray.SumMix(data);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SumMix_ReturnsZero_WhenNoIntsExsist()
        {
            object[] data = ["Dog", "Apple","north"];
            int expected = 0;

            int result = SumMixedArray.SumMix(data);

            Assert.Equal(expected, result);
        }


    }
}
