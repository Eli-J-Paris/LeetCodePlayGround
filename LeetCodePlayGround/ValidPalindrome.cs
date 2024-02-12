using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.*/

namespace LeetCodePlayGround
{
    public class ValidPalindrome
    {
        //take the string remove any non alpha numeric character
        //perserve the new string 
        //turn that string into an array
        //reverse that array
        //turn that array back into a string
        //compare if the strings are the same if yes return true if not return false
        
        /// <summary>
        /// checks if a string is a palindrome sweeeeeet
        /// </summary>
        /// <param name="s"></param>
        /// <returns>true if the string is a palindrome, otherwise returns false</returns>
        public static bool IsPalindrome(string s)
        {
            string newString = "";

            foreach(var character in s)
            {
                if (char.IsLetterOrDigit(character))
                {
                    newString += character;
                }
            }

            newString = newString.ToLower();

            char[] charArray = newString.ToArray();
            Array.Reverse(charArray);
            string reversedString = string.Join("",charArray);

            Console.WriteLine("NS: " + newString);
            Console.WriteLine($"RS: {reversedString}");
            if (newString == reversedString)
                return true;
            else
                return false;        
        }
    }
}







































//var indexingArray = s.ToLower().ToArray();
//string[] newStringArray = new string[s.Length];


//for (int i = 0; i < s.Length; i++)
//{
//    if (char.IsLetterOrDigit(indexingArray[i]))
//    {
//        newStringArray[i] = indexingArray[i].ToString();
//    }
//}

//Array.Reverse(newStringArray);
//string str = "";
//foreach (var c in newStringArray)
//{
//    str += c;
//}

//if (newStringArray.ToString() == str)
//{
//    Console.WriteLine($"s:{newStringArray.ToString()}");
//    Console.WriteLine($"str: {str}");
//    return true;
//}

//else
//{
//    Console.WriteLine($"s:{s}");
//    Console.WriteLine($"str: {str}");
//    return false;
//}
