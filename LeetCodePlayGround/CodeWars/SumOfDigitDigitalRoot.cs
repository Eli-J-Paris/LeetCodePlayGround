using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/541c8630095125aba6000c00
namespace LeetCodePlayGround.CodeWars
{
    public class SumOfDigitDigitalRoot
    {
        public static int DigitalRoot(long num)
        {
            //the exit
            if (num < 10)
            {
                return Convert.ToInt32(num);
            }


            long sum = 0;
            long tempnum = num;
            while (tempnum > 0)
            {
                long digit = tempnum % 10;
                sum += digit;
                tempnum = tempnum / 10;
            }

            return DigitalRoot(sum);

        }
    }
}
