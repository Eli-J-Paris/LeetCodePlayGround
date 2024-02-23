using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class VowelCountTests
    {
        [Fact]
        public static void GetVowelCount_ReturnsCountofVowels_InString()
        {
            string input = "aeiou";
            int expected = 5;

            int result = VowelCount.GetVowelCount(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void GetVowelCount_ReturnsCountofVowels_InString_2()
        {
            string input = "helloworld";
            int expected = 3;

            int result = VowelCount.GetVowelCount(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void GetVowelCount_ReturnsCountofVowels_InString_3()
        {
            string input = "ghtrwqvx";
            int expected = 0;

            int result = VowelCount.GetVowelCount(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void GetVowelCount_Returns0_IfStringIsEmpty()
        {
            string input = string.Empty;
            int expected = 0;

            int result = VowelCount.GetVowelCount(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void GetVowelCount_Returns0_IfString_isJustSpaces()
        {
            string input = "   ";
            int expected = 0;

            int result = VowelCount.GetVowelCount(input);

            Assert.Equal(expected, result);
        }
    }
}
