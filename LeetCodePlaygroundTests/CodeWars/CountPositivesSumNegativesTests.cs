using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class CountPositivesSumNegativesTests
    {

        [Fact]
        public void Solution_ReturnsIntArryWithCountOfPositiveInts_AND_SumNegativeInts()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15];
            int[] expected = [10, -65];

            int[] result = CountPositivesSumNegatives.Solution(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsIntArryWithCountOfPositiveInts_AND_SumNegativeInts_2()
        {
            int[] nums = [-1,1];
            int[] expected = [1, -1];

            int[] result = CountPositivesSumNegatives.Solution(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsIntArryWithCountOfPositiveInts_AND_SumNegativeInts_3()
        {
            int[] nums = [-1,4,6,3,25,9,-5,-5];
            int[] expected = [5, -11];

            int[] result = CountPositivesSumNegatives.Solution(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsEmptyArrayWhenEmpty()
        {
            int[] nums = [];
            int[] expected = Array.Empty<int>();

            var result = CountPositivesSumNegatives.Solution(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_ReturnsEmptyArrayWhenNull()
        {
            int[] nums = null;
            int[] expected = Array.Empty<int>();

            var result = CountPositivesSumNegatives.Solution(nums);

            Assert.Equal(expected, result);
        }
    }
}
