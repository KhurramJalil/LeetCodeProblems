using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class Atoi
    {
        public static int SolveIt(string s)
        {
            int sign = 1,
                result = 0,
                k = 0;
            if (!string.IsNullOrEmpty(s))
            {
                while (s[k] == ' ') k++;

                if (s[k] == '-' || s[k] == '+')
                {
                    sign = s[k] == '-' ? -1 : 1;
                    k++;
                }

                while (k < s.Length && s[k] >= '0' && s[k] <= '9')
                {
                    if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && s[k] - '0' > 7))
                    {
                        return sign == 1 ? int.MaxValue : int.MinValue;
                    }
                    result = result * 10 + s[k++] - '0';
                }
            }
            return result * sign;
        }
    }
}
