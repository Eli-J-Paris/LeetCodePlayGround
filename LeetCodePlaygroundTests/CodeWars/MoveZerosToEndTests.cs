using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class MoveZerosToEndTests
    {
        [Fact]
        public static void MoveZeros_MovesAllZerosToTheEndOfArry_WhileMaintaingOrderOf_AllNonZeroInt()
        {
            int[] numarry = [1, 2, 0, 0, 3, 0, 4, 5];
            int[] expected = [1, 2, 3, 4, 5, 0, 0, 0];

            int[] result = MoveZerosToEnd.MoveZeros(numarry);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void MoveZeros_MovesAllZerosToTheEndOfArry_WhileMaintaingOrderOf_AllNonZeroInt_2()
        {
            int[] numarry = [5,0,1];
            int[] expected = [5,1,0];

            int[] result = MoveZerosToEnd.MoveZeros(numarry);

            Assert.Equal(expected, result);
        }
    }
}
