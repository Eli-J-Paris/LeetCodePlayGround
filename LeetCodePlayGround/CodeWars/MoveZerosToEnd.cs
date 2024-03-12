using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    public class MoveZerosToEnd
    {
        //public static int[] MoveZeros(int[] numarry)
        //{
        //    int[] result = new int[numarry.Length];
        //    int numOfZeros = 0;
        //    for (int i = 0; i < numarry.Length; i++)
        //    {
        //        if (numarry[i] != 0)
        //        {
        //            result[i] = numarry[i];
        //        }
        //        else
        //        {

        //            numOfZeros++;
        //        }
        //    }

        //    for (int i = 0; i < numOfZeros; i++)
        //    {
        //        result.Append(0);
        //    }
        //    return result;
        //}


        //public static int[] MoveZeros(int[] numarry)
        //{
        //    List<int> result = new List<int>();

        //    int numOfZeros = 0;
        //    for (int i = 0; i < numarry.Length; i++)
        //    {
        //        if (numarry[i] != 0)
        //        {
        //            result.Add(numarry[i]);
        //        }
        //        else
        //        {
        //            numOfZeros++;
        //        }
        //    }
        //    for (int i = 0; i < numOfZeros; i++)
        //    {
        //        result.Add(0);
        //    }

        //    return result.ToArray();
        //}

        //CHATGPT
        public static int[] MoveZeros(int[] numarray)
        {
            int[] result = new int[numarray.Length];
            int nonZeroIndex = 0;

            // Copy non-zero elements to the result array
            for (int i = 0; i < numarray.Length; i++)
            {
                if (numarray[i] != 0)
                {
                    result[nonZeroIndex] = numarray[i];
                    nonZeroIndex++;
                }
            }

            // Fill the remaining slots with zeros
            for (int i = nonZeroIndex; i < result.Length; i++)
            {
                result[i] = 0;
            }

            return result;
        }
    }
}
