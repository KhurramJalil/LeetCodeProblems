using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class RecursivelyReverseString
    {
        public static void SolveIt(string s)
        {
            if (!string.IsNullOrEmpty(s))
                SolveIt(s.Substring(1));
            //Either of the following will work
            Console.Write(s.FirstOrDefault());
            //OR
            //Console.Write(s.Substring(0, 1));
        }
    }
}
