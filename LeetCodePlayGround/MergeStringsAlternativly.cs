using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.*/




namespace LeetCodePlayGround
{
    public class MergeStringsAlternativly
    {
        //Input: word1 = "abc", word2 = "pqr"
        //Output: "apbqcr"

        //Input: word1 = "ab", word2 = "pqrs"
        //Output: "apbqrs"
        public static string MergeTwoStringsAlternativly(string word1, string word2)
        {
            int longestLength = 0;

            if (word1.Length >= word2.Length)
                longestLength = word1.Length;
            else
                longestLength = word2.Length;


            string mergedString = string.Empty;

            for (int i = 0; i < longestLength; i++)
            {
                try
                {
                    mergedString += word1[i];
                }
                catch
                {

                }

                try
                {
                    mergedString += word2[i];
                }
                catch
                {

                }
            }
            return mergedString;







        //    int longestLength = 0;
        //    string mergedString = string.Empty;
        //    if (word1.Length >= word2.Length)
        //        longestLength = word1.Length;
        //    else
        //        longestLength = word2.Length;

        //    for (int i = 0; i < longestLength; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            mergedString += word1[i];
        //        }
        //        else
        //        {
        //            mergedString += word2[i];
        //        }
        //    }

        //    return mergedString;
        }

    }
}
