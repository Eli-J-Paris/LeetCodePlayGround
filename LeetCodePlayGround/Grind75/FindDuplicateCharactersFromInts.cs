using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.Grind75
{
    public class FindDuplicateCharactersFromInts
    {
        //inside of the string tell if there is another occurance of that character(closest occurance) from the list of ints and return the new index positions
        //E.g. s = hello, queries = 0,2| -1,3 h occures once l occrers twice one at 2(the given) and 3 the next closest


        //break down s into a char array
        //for loop over the count of quereis
        //pull out a character from s based on i from the queries
        //inner for loop over the chararry to find closest duplicate;
        public static void Solution(string s, List<int> queries)
        {
            char[] charArry = s.ToArray();
            List<int> indexes = new List<int>();

            for (int i = 0; i < queries.Count; i++)
            {
                char character = charArry[queries[i]];
                // Console.WriteLine(character);

                foreach (var c in charArry)
                {
                    if (c == character)
                    {
                        indexes.Add(Array.IndexOf(charArry, c));
                    }
                }
            }


            foreach (var num in indexes)
            {
                Console.WriteLine(num);
            }

        }
    }
}
