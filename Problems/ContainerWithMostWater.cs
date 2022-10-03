using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class ContainerWithMostWater
    {
        public static int SolveIt(int[] height)
        {
            int left = 0,
            right = height.Length - 1,
            area = 0;

            while (left < right)
            {
                area = Math.Max(area, Math.Min(height[left], height[right]) * (right - left));

                if (height[left] < height[right])
                    left += 1;
                else
                    right -= 1;
            }
            return area;
        }
    }
}
