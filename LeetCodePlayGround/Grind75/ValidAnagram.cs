using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.Grind75
{
    public class ValidAnagram
    {

        public static bool IsAnagram(string anagram, string potentialAnagram)
        {

            if (anagram.Length != potentialAnagram.Length)
                return false;

            List<char> listOfChars = potentialAnagram.ToList();

            foreach (var character in anagram)
            {
                if (listOfChars.Contains(character))
                {
                    listOfChars.Remove(character);
                }
            }

            if (listOfChars.Count == 0)
                return true;
            else
                return false;
        }

        public static bool IsAnagramSort(string anagram, string potentialAnagram)
        {
            if (anagram.Length != potentialAnagram.Length)
                return false;


            string sortedAnagram = string.Concat(anagram.OrderBy(c => c));
            string sortedPotentialAnagram = string.Concat(potentialAnagram.OrderBy(c => c));

            //Console.WriteLine(sortedAnagram);
            //Console.WriteLine(sortedPotentialAnagram);

            if (sortedAnagram == sortedPotentialAnagram)
                return true;
            else
                return false;


        }

    }
}
