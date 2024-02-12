using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround
{
    public class RomanNumeralToInt
    {

        public static int ConvertToInt(string romanNumeral)
        {
            int sum = 0;

            Dictionary<string, int> romanNumeralChart = new Dictionary<string, int>()
            {
                {"I", 1 },
                {"V", 5 },
                {"X", 10 },
                {"L", 50 },
                {"C", 100 },
                {"D", 500 },
                {"M", 1000 }
            };

            romanNumeral = romanNumeral.Replace("IV", "IIII")
                                       .Replace("IX", "VIIII")
                                       .Replace("XL", "XXXX")
                                       .Replace("XC", "LXXXX")
                                       .Replace("CD", "CCCC")
                                       .Replace("CM", "DCCCC");

            foreach(char numeral in romanNumeral)
            {
                sum += romanNumeralChart[numeral.ToString()];
            }

            return sum;
        }


    }
}
