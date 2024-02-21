using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://codewars.com/kata/57eaeb9578748ff92a000009/train/csharp

//Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

//Return your answer as a number.

namespace LeetCodePlayGround.CodeWars
{
    public class SumMixedArray
    {
        //public static int SumMix(object[] x)
        //{
        //    int sum = 0;
        //    foreach(var element in x)
        //    {

        //        if (element is int)
        //        {
        //            sum += Convert.ToInt32(element);
        //        }
        //        else
        //        {
        //            try
        //            {
        //                sum += Convert.ToInt32(element);
        //            }
        //            catch
        //            {
        //                continue;
        //            }
        //        }

        //    }

        //    return sum;
        //}

        public static int SumMix(object[] x)
        {
            int sum = 0;
            foreach (var element in x)
            {
                if (element is int)
                {
                    sum += (int)element;
                }
                else if (element is string)
                {
                    int num;
                    if (int.TryParse((string)element, out num))
                    {
                        sum += num;
                    }
                    
                }
            }
            return sum;
        }
    }
}
