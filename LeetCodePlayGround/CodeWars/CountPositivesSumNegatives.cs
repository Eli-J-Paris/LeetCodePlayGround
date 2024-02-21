using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given an array of integers.

//Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

//If the input is an empty array or is null, return an empty array.

//Example
//For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
namespace LeetCodePlayGround.CodeWars
{
    public class CountPositivesSumNegatives
    {
        public static int[] Solution(int[] nums)
        {
            int[] intArry = new int[2];

            if (nums == null || nums.Length == 0) { return Array.Empty<int>(); } 

            int positiveCount = 0;
            int negativeSum = 0;

            foreach(var num in nums)
            {
                if(num > 0)
                {
                    positiveCount++;
                }
                else if( num < 0)
                {
                    negativeSum += num;
                }
            }

            intArry[0] = positiveCount;
            intArry[1] = negativeSum;

            return intArry;

        }

    }
}
