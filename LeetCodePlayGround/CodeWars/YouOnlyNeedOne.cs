using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://codewars.com/kata/57cc975ed542d3148f00015b/train/csharp
//You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.

//Array can contain numbers or strings. X can be either.

//Return true if the array contains the value, false if not
namespace LeetCodePlayGround.CodeWars
{
    public class YouOnlyNeedOne
    {
        public static bool Solution(object[]a, object x)
        {
            foreach (object item in a)
            {
                if (item.ToString() == x.ToString()) return true;
            }

            return false;
        }
    }
}
