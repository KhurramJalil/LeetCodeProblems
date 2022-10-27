using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class ValidBrackets
    {
        //https://leetcode.com/problems/valid-parentheses/
        public static bool SolveIt(string s)
        {
            var myStack = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                //Check if current character is any of the 3 opening brackets
                if ("({[".IndexOf(s[i]) > -1)
                {
                    myStack.Push(s[i]);
                }
                else
                {
                    //Found a closing bracket when stack is empty
                    if (myStack.Count == 0)
                        return false;

                    var oBracket = Convert.ToChar(myStack.Peek());
                    if (
                        (oBracket == '(' && s[i] == ')')
                        || (oBracket == '{' && s[i] == '}')
                        || (oBracket == '[' && s[i] == ']')
                        )
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return myStack.Count == 0;
        }
    }
}
