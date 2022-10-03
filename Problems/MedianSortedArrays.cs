using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class MedianSortedArrays
    {
        public static double SolveIt(int[] nums1, int[] nums2)
        {
            int m = nums1.Length,
                n = nums2.Length,
                i = 0, j = 0, k = 0;

            int[] merged = new int[m + n];

            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                    merged[k++] = nums1[i++];
                else
                    merged[k++] = nums2[j++];
            }

            while (i < m)
                merged[k++] = nums1[i++];

            while (j < n)
                merged[k++] = nums2[j++];

            int medianIndex = merged.Length / 2;

            if (merged.Length % 2 > 0)
            {
                return merged[medianIndex];
            }
            else
            {
                return (merged[medianIndex - 1] + merged[medianIndex]) / 2.0;
            }
        }
    }
}
