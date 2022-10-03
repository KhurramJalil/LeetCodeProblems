using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class IntegerReverse
    {
        public static int SolveIt(int x)
        {
            int reverse = 0;

            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;

                if ((reverse > (int.MaxValue / 10) || reverse == int.MaxValue / 10 && x > 7) || (reverse < (int.MinValue / 10) || reverse == (int.MinValue / 10) && x < -8))
                {
                    reverse = 0;
                    break;
                }
                reverse = reverse * 10 + pop;
            }
            return reverse;
        }
    }
}
