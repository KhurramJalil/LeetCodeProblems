using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class TwoSum
    {
        public static int[] SolveIt(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var compliment = target - nums[i];
                if (map.ContainsKey(compliment))
                {
                    return new int[] { map[compliment], i };
                }
                else
                {
                    map[nums[i]] = i;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
