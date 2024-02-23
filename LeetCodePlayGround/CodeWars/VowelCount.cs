using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            List<char> vowels = new List<char> { 'a','e','i','o','u' };
            int sum = 0;
            foreach(char c in str)
            {
                if (vowels.Contains(c))
                {
                    sum++;
                }
            }
            return sum;
;        }
    }
}
