using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class LongestPalindromeSubstring
    {
        public static string SolveIt(string s)
        {
            int length = 0, startIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                CheckFromMiddle(s, i, i, ref length, ref startIndex);
                CheckFromMiddle(s, i, i + 1, ref length, ref startIndex);
            }
            return s.Substring(startIndex + 1, length);
        }

        static void CheckFromMiddle(string s, int i, int j, ref int length, ref int startIndex)
        {
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }

            if (j - i - 1 > length)
            {
                length = j - i - 1;
                startIndex = i;
            }
        }
    }
}
