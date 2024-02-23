using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.

//Examples (input -> output)
//6, "I"     -> "I I I I I I"
//5, "Hello" -> "HelloHelloHelloHelloHello"



namespace LeetCodePlayGround
{
    public class StringRepeat
    {
        public static string RepeatStr(int n, string s)
        {
            string newstring = string.Empty;

            for (int i = 0; i < n; i++)
            {
                newstring += s;
            }

            return newstring;
        }
    }
}
