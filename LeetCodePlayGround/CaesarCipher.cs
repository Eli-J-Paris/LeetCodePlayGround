using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround
{
    public class CaesarCipher
    {
        //iterate through each letter in message // for loop we need I for the index
        //need an empty string builder type string to keep track of the new message
        //an alphabet array for all 26 letters of the alphabet
        //find the index of the letter in message
        //relate it to the alphabet array and add 3 or X
        //append the new letter to the string builder
        //do this for every letter
        //return new string

        public static string Encrypt(string message)
        {
            StringBuilder sb = new StringBuilder();
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            message = message.ToLower();

            //z = 0 + 3, letterindex = 25 -25 = 0+3;
            //y = 0 + 2, letterindex= 25 -24 = 1+ 
            //x = 0 + 1
            for (int i = 0; i < message.Length; i++)
            {
                int letterIndex = Array.IndexOf(alphabet, message[i]);

                if (letterIndex + 3 > 25)
                {
                    //int j = ;
                    sb.Append(alphabet[0 + 3 - (26 - letterIndex)]);
                }
                else
                {
                    sb.Append(alphabet[letterIndex + 3]);
                }
            }
            return sb.ToString();
        }

        public static string Decode(string message)
        {
            StringBuilder sb = new StringBuilder();
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            message = message.ToLower();
            for (int i = 0; i < message.Length; i++)
            {
                int letterIndex = Array.IndexOf(alphabet, message[i]);

                if (letterIndex - 3 < 0)
                {
                    //int j = ;
                    sb.Append(alphabet[26 + 3 - (26 - letterIndex)]);
                }
                else
                {
                    sb.Append(alphabet[letterIndex - 3]);
                }
            }
            return sb.ToString();
        }
     }
  } 

