using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class SquareEveryDigitTests
    {
        [Fact]
        public static void SquareDigits_SqauresEachnumberAndConcatsThemTogether()
        {
            int num = 55;
            int expected = 2525;

            int result = SquareEveryDigit.SquareDigits(num);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void SquareDigits_SqauresEachnumberAndConcatsThemTogether_2()
        {
            int num = 94;
            int expected = 8116;

            int result = SquareEveryDigit.SquareDigits(num);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void SquareDigits_SqauresEachnumberAndConcatsThemTogether_3()
        {
            int num = 1;
            int expected = 1;

            int result = SquareEveryDigit.SquareDigits(num);

            Assert.Equal(expected, result);
        }
    }
}
