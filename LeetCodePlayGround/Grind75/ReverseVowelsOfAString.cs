using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.Grind75
{
    //hello => holle
    //turn s .tolower()
    //char[] that holds the values
    //? turn s into a char[]
    //foreach over s
    //if it a vowel go to the end of the new s array
    //find the last vowel and replace it


    public class ReverseVowelsOfAString
    {
        public static string ReverseVowels(string s)
        {
            char[] charArray = new char[s.Length];
            charArray = s.ToArray();
            char[] lowerVowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] upperVowels = { 'A', 'E', 'I', 'O', 'U' };
            List<char> lowerVowelsList = new List<char>();
            List<char> upperVowelsList = new List<char>();

            foreach (char c in charArray)
            {
                if (lowerVowels.Contains(c))
                {
                    lowerVowelsList.Add(c);
                }
                else if (upperVowels.Contains(c))
                {
                    upperVowelsList.Add(c);

                }
            }

            lowerVowelsList.Reverse();
            upperVowelsList.Reverse();

            string newString = string.Empty;
            int j = 0;
            int k = 0;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                char currentChar = charArray[i];
                if (lowerVowels.Contains(currentChar))
                {
                    Console.WriteLine("lv");
                    newString += charArray[i].ToString().Replace(currentChar, lowerVowelsList[j]);
                    j++;
                }
                else if (upperVowels.Contains(currentChar))
                {
                    Console.WriteLine("UV");
                    newString += charArray[i].ToString().Replace(currentChar, upperVowelsList[k]);
                    k++;
                }
                else
                {
                    Console.WriteLine("C");
                    newString += currentChar;
                }
            }


            return newString;


        }

        public static string ReverseVowelsWithStack(string s)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder sb = new StringBuilder();

            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

            foreach (char c in s)
            {
                if (vowels.Contains(c))
                {
                    stack.Push(c);
                }
            }

            foreach (char c in s)
            {
                if (vowels.Contains(c))
                {
                    sb.Append(stack.Pop());
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();

        }
    }

}
