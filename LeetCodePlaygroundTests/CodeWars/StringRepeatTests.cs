using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class StringRepeatTests
    {

        [Fact]
        public void RepeatStrRepeats_I_3Times()
        {
            int n = 3;
            string s = "I";

            string expected = "III";
            string result = StringRepeat.RepeatStr(n, s);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void RepeatStrRepeats_Dog_2Times()
        {
            int n = 2;
            string s = "Dog";

            string expected = "DogDog";
            string result = StringRepeat.RepeatStr(n, s);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void RepeatStr_ReturnsEmptyString_IfStringIsEmpty()
        {
            int n = 3;
            string s = "";

            string expected = "";
            string result = StringRepeat.RepeatStr(n, s);

            Assert.Equal(expected, result);

        }

    }
}
