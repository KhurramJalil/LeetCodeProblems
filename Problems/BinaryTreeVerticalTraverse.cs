using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class BinaryTreeVerticalTraverse
    {
        //[0,-1,1,-2,0,0]
        //[3,1,4,0,2,2]
        public static IList<IList<int>> SolveIt(TreeNode root)
        {
            var result = new List<IList<int>>();
            var valuesPerVIndex = new SortedDictionary<int, List<int>>();
            FillAllInSameVIndex(root, 0, valuesPerVIndex);

            foreach (var kvp in valuesPerVIndex)
            {
                result.Add(kvp.Value.OrderBy(y => y).ToList());
            }

            return result;
        }

        static void FillAllInSameVIndex(TreeNode currNode, int index, SortedDictionary<int, List<int>> result)
        {
            if (currNode != null)
            {
                if (result.ContainsKey(index))
                {
                    result[index].Add(currNode.val);
                }
                else
                {
                    result.Add(index, new List<int>() { currNode.val });
                }

                FillAllInSameVIndex(currNode.left, index - 1, result);
                FillAllInSameVIndex(currNode.right, index + 1, result);
            }
        }
    }
}
