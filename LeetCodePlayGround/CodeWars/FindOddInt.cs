using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
namespace LeetCodePlayGround.CodeWars
{
    public class FindOddInt
    {
        public static int FindInt(int[] nums)
        {
            Dictionary<int, int> kvp = new Dictionary<int, int>();
            foreach(var n in nums)
            {
                if (kvp.ContainsKey(n))
                {
                    kvp[n]++;
                }
                else
                {
                    kvp[n] = 1;
                }
            }
           
            int oddNum = 0;
            foreach(var pair in kvp)
            {
                if(pair.Value % 2 != 0)
                {
                    oddNum = pair.Key;
                }
            }

            return oddNum;
        }
    }
}
