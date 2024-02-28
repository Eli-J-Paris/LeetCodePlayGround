using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    public class DescendingOrder
    {
        public static int OrderDescending(int num)
        {
            string strnum = num.ToString();
            int[] numarry = num.ToString().Select(n => Convert.ToInt32(n)-48).ToArray();

            Array.Sort(numarry);
            Array.Reverse(numarry);
            string result = String.Join("",numarry);
           
            return Convert.ToInt32(result);

        }
    }
}
