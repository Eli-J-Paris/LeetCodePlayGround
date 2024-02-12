using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int num = Array.IndexOf(nums, target);
            return num;
        }

        //public static int Search(int target , int[] nums)
        //{
        //    int num = Array.BinarySearch(nums, target);
        //    return num;
        //}

        //1,2,3,4,5,6,7,8,9,10 && 11
        public static int Search(int target, int[] nums)
        {
            int min = 0;
            int max = nums.Length - 1;


            while(min <= max)
            {
                int mid = (min + max) / 2;
                Console.WriteLine(mid);
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    max = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    min = mid + 1;
                }
            }

            return -1;
        }
    }
}
