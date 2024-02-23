using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class DisemvowelTrollsTests
    {

        [Fact]
        public static void Disemvowel_RemovesAllVowelsFromString()
        {
            string message = "helloWorld";
            string expected = "hllWrld";

            string result = DisemvowelTrolls.Disemvowel(message);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void Disemvowel_RemovesAllVowelsFromString_2()
        {
            string message = "Looooool";
            string expected = "Ll";

            string result = DisemvowelTrolls.Disemvowel(message);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void Disemvowel_RemovesAllVowelsFromString_3()
        {
            string message = "No offense but,\nYour writing is among the worst I've ever read";
            string expected = "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd";
            
            string result = DisemvowelTrolls.Disemvowel(message);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void Disemvowel_returnsEmptystringWhenInputMessageisEmpty()
        {
            string message = string.Empty;
            string expected = string.Empty;

            string result = DisemvowelTrolls.Disemvowel(message);

            Assert.Equal(expected, result);
        }
        [Fact]
        public static void Disemvowel_returnsEmptystringWhenInputMessageisNull()
        {
            string message = null;
            string expected = string.Empty;

            string result = DisemvowelTrolls.Disemvowel(message);

            Assert.Equal(expected, result);
        }

    }
}
