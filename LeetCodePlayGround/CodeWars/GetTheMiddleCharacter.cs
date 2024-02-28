using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
namespace LeetCodePlayGround.CodeWars
{
    public class GetTheMiddleCharacter
    {
        public static string GetMiddle(string str)
        {
            string result = "";
            int mid = str.Length / 2;
            if (str.Length % 2 == 0)
            {
                result = str[mid -1] + str[mid].ToString();
            }
            else
            {
                result = str[mid].ToString();
            }

            return result;
        }
    }
}
