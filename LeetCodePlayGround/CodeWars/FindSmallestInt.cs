using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    public class FindSmallestInt
    {
        public static int FindSmallestIntInArry(int[] nums)
        {
            int minValue = int.MaxValue;
  
            for (int i = 0; i < nums.Length; i++)
            {
                if(minValue > nums[i])
                {
                    minValue = nums[i];
                }
            }

            return minValue;
        }
    }
}
