using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class SumOfDigitDigitalRootTests
    {
        [Fact]
        public static void DigitalRoot_SumAllNumbersRecoursively()
        {
            long num = 16;
            int expected = 7;

            int result = SumOfDigitDigitalRoot.DigitalRoot(num);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void DigitalRoot_SumAllNumbersRecoursively_2()
        {
            long num = 942;
            int expected = 6;

            int result = SumOfDigitDigitalRoot.DigitalRoot(num);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void DigitalRoot_SumAllNumbersRecoursively_3()
        {
            long num = 132189;
            int expected = 6;

            int result = SumOfDigitDigitalRoot.DigitalRoot(num);

            Assert.Equal(expected, result);
        }
    }
}
