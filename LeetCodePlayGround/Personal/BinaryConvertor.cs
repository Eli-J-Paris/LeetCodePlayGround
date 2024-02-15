using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.Personal
{       //Math.Pow()
    public class BinaryConvertor
    {
        /// <summary>
        /// Converts an int into a binary string
        /// </summary>
        /// <param name="num"></param>
        /// <returns> a string that represents the binary num of the number passed in</returns>
        public static string ConvertNumberToBinary(int num)
        {
            //if num is zero return early
            if (num == 0) return "0";

            //preparing the varibles we will need
            string binaryString = "";
            double quotient;

            //Run while num is greater than zero. loop will always reach zero on its own unless num is 0 hence the above if statement
            while (num > 0)
            {
                //getting the quotient as a double !important
                quotient = (double)num / 2;
                //checking if quotient has a remainder
                if (quotient > num / 2)
                {
                    //Addding 1 to the front of the string if quotient does have a remainder
                    binaryString = "1" + binaryString;
                    //assigning num as quotient as an int I.E. we no longer need a remainder on this pass
                    num = (int)quotient;
                }
                //could replace with else, but is asking if quotient DOES NOT have a remainder
                else if (quotient == num / 2)
                {
                    //adding 0 to front of the string
                    binaryString = "0" + binaryString;
                    //assigning num to quotient int
                    num = (int)quotient;
                }
            }

            //return the newly formatted binary string
            return binaryString;
        }


        /// <summary>
        /// Converts a base2 int to a base 10 int
        /// </summary>
        /// <param name="binaryNum"></param>
        /// <returns>a base 10 int</returns>
        public static int ConvertBinaryToNumber(int binaryNum)
        {
            char[] binaryStringArry = binaryNum.ToString().ToArray();
            Array.Reverse(binaryStringArry);

            double sum = 0;
            for (int i = 0; i < binaryStringArry.Length; i++)
            {
                if (binaryStringArry[i] == '1')
                    sum += 1 * Math.Pow(2, i);

                else if (binaryStringArry[i] == '0')
                    sum += 0 * Math.Pow(2, i);
            }

            return Convert.ToInt32(sum);
        }

        /// <summary>
        /// Converts a string down to binary
        /// </summary>
        /// <param name="s"></param>
        /// <returns>returns a string of binary numbers</returns>
        public static string ConvertStringToBinary(string s)
        {
            StringBuilder sb = new StringBuilder();
            List<int> asciiNums = new List<int>();

            foreach (char c in s)
            {
                asciiNums.Add(ConvertCharToASCII(c));
            }

            foreach (var num in asciiNums)
            {
                string binaryNum = ConvertNumberToBinary(num);
                sb.Append(binaryNum + " ");
            }


            return sb.ToString();
        }

        /// <summary>
        /// Converts a character into its ASCII value
        /// </summary>
        /// <param name="c"></param>
        /// <returns>an int</returns>
        public static int ConvertCharToASCII(char c)
        {
            return Convert.ToInt32(c);
        }

    }












    //while (true)
    //{
    //    string userInput; ;
    //    while (true)
    //    {
    //        Console.WriteLine("1: Convert Base 10 to Base 2\n2: Convert Base 2 to Base 10");
    //        userInput = Console.ReadLine().ToString();

    //        if (userInput == "1"|| userInput == "2")
    //        {
    //            break;
    //        }
    //        else
    //        {
    //            Console.Clear();
    //            Console.WriteLine("INVALID INPUT");
    //        }

    //    }

    //    if(userInput == "1")
    //    {
    //        Console.Clear();
    //        Console.Write("enter in a Base 10 number:");
    //        string num = Console.ReadLine();
    //        string result = BinaryConvertor.ConvertNumberToBinary(Convert.ToInt32(num));

    //        Console.WriteLine(num + " in base 2 is: " + result);
    //    }
    //    else
    //    {
    //        Console.Clear();
    //        Console.Write("enter in a Base 2 number:");
    //        string num = Console.ReadLine();
    //        int result = BinaryConvertor.ConvertBinaryToNumber(Convert.ToInt32(num));

    //        Console.WriteLine(num + " in base 10 is: " + result);
    //    }

    //}
}
