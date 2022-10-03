using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class TrappingRainWater
    {
        public static int SolveIt(int[] height)
        {
            int left = 0,
                right = height.Length - 1,
                lMax = 0,
                rMax = 0,
                result = 0;

            while (left <= right)
            {
                if (rMax <= lMax)
                {
                    result += Math.Max(0, rMax - height[right]);
                    rMax = Math.Max(rMax, height[right]);
                    right -= 1;
                }
                else
                {
                    result += Math.Max(0, lMax - height[left]);
                    lMax = Math.Max(lMax, height[left]);
                    left += 1;
                }
            }
            return result;
        }
    }
}
