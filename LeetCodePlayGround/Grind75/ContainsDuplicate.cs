using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.Grind75
{
    public class ContainsDuplicate
    {
        //1,2,3,4 = false
        //1,2,3,1 = true
        public static bool ArrayContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            int j = nums.Length + 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i == j) return false;

                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
                else if (nums[j] == nums[j - 1])
                {
                    return true;
                }
                j--;
            }

            return false;
        }
    }
}
