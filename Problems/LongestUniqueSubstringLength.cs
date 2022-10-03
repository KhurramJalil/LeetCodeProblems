using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class LongestUniqueSubstringLength
    {
        public static int SolveIt(string s)
        {
            var test = string.Empty;
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var currChar = s[i];

                // If string already contains the character then substring after repeating character
                if (test.Contains(currChar))
                {
                    test = test.Substring(test.IndexOf(currChar) + 1);
                }
                test = test + currChar.ToString();
                maxLength = Math.Max(test.Length, maxLength);
            }
            return maxLength;
        }
    }
}
