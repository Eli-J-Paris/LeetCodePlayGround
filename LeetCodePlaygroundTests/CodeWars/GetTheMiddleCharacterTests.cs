using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class GetTheMiddleCharacterTests
    {
        [Fact]
        public static void GetMiddle_ReturnsMiddleCharacterifstringLengthIsOdd()
        {
            string str = "abc";
            string expected = "b";

            string result = GetTheMiddleCharacter.GetMiddle(str);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void GetMiddle_ReturnsMiddleCharacterifstringLengthIsOdd_2()
        {
            string str = "abcdefg";
            string expected = "d";

            string result = GetTheMiddleCharacter.GetMiddle(str);

            Assert.Equal(expected, result);
        }


        [Fact]
        public static void GetMiddle_ReturnsTwoMiddleCharactersifStringLengthIsEven()
        {
            string str = "abcd";
            string expected = "bc";

            string result = GetTheMiddleCharacter.GetMiddle(str);

            Assert.Equal(expected, result);
        }
    }
}
