using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//DESCRIPTION
/*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.


Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false*/
namespace LeetCodePlayGround.Grind75
{
    public class ValidParentheses
    {

        public static bool IsValidParentheses(string s)
        {
            //check if the length of the string is 0 or 1. If true the string is already invalid
            if (s.Length <= 1) return false;

            //create a new empty stack
            Stack<char> stack = new Stack<char>();

            //loop over each character in the incoming string
            foreach (var character in s)
            {
                //if the character is (, {, [ push(Add) it to the top of the stack
                if (character == '(' || character == '{' || character == '[')
                {
                    stack.Push(character);
                }
                // else the character is ), }, ]
                else
                {
                    //handels stack.empty exception e.g. the incoming string is "){". ) isn't added to the empty stack so when stack.Peek() is run the code breaks because the stack is empty
                    if (stack.Count == 0) return false;

                    //stack.Peek() checks the top of the stack and if the parentheses match pop off the top parenthese
                    if (stack.Peek() == '(' && character == ')' || stack.Peek() == '{' && character == '}' || stack.Peek() == '[' && character == ']')
                    {
                        //Removes the top/peek of the stack
                        stack.Pop();
                    }
                    else
                    {
                        //if the above if statment isn't met its safe to assume the string is invalid 
                        return false;
                    }
                }
            }

            //Insures that the stack must be empty for the string to be valid. Without it string like: "((" would slip by because the first if statment inside the for loop is hit twice and misses the else
            if (stack.Count != 0)
                return false;
            //if we get this far the string is valid.
            else
                return true;

        }
    }
}
