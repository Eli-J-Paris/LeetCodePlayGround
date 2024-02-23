using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    public class DisemvowelTrolls
    {
        public static string Disemvowel(string message)
        {
            if (message == null) return string.Empty;
            
            StringBuilder sb = new StringBuilder();
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U' };
            foreach(var c in message)
            {
                if (!vowels.Contains(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
