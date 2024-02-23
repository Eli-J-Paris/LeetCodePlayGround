using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad/train/csharp
//Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

//invert([1,2,3,4,5]) == [-1, -2, -3, -4, -5]
//invert([1, -2, 3, -4, 5]) == [-1, 2, -3, 4, -5]
//invert([]) == []

namespace LeetCodePlayGround.CodeWars
{
    public class InvertValues
    {
        public static int[] ArrayInversion(int[] nums)
        {
            int[] invertedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (Int32.IsPositive(nums[i]))
                {
                    invertedNums[i] = nums[i] - (nums[i] * 2);
                }
                else if (Int32.IsNegative(nums[i]))
                {
                    //this is called the unary negation operator which turns a negative int to its postive counter part and VICE VERSA^^^^
                    invertedNums[i] = -nums[i]; 
                }
            }

            return invertedNums;

        }
    }
}
