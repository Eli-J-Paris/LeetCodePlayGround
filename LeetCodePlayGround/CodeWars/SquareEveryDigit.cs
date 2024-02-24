using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    public class SquareEveryDigit
    {
        public static int SquareDigits(int num)
        {
            string sqauredStr = string.Empty;
            string strnum = num.ToString();
            
            foreach(var n in strnum)
            {
                int i = Convert.ToInt32(n.ToString());
                sqauredStr += (i * i).ToString();
            }

            return Int32.Parse(sqauredStr);
        }
    }
}
