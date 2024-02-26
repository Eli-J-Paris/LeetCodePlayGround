using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp
//In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

//Examples
//Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
//Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
//Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
//Notes
//All numbers are valid Int32, no need to validate them.
//There will always be at least one number in the input string.
//Output string must be two numbers separated by a single space, and highest number is first.

namespace LeetCodePlayGround.CodeWars
{
    public class HighestAndLowest
    {
        public static string HighAndLow(string nums)
        {
            string[] strArray = nums.Split(' ');
            int[] numsArray = new int[strArray.Length];

            for (int i = 0; i < numsArray.Length; i++)
            {
                Int32.TryParse(strArray[i], out numsArray[i]);
            }

            int min = numsArray.Min();
            int max = numsArray.Max();

            return $"{max} {min}";
        }
    }
}
