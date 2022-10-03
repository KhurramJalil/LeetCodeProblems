using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class BinarySearchArray
    {
        public static int SolveIt(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        static int BinarySearch(int[] nums, int low, int high, int target)
        {
            int mid = (low + high) / 2;

            while (low < high)
            {
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    return BinarySearch(nums, ++mid, high, target);
                }
                else
                {
                    return BinarySearch(nums, low, --mid, target);
                }
            }
            return -1;
        }
    }
}
