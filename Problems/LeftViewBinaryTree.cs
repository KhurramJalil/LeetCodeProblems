using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class LeftViewBinaryTree
    {
        public static IList<int> SolveIt(TreeNode root)
        {
            var visitedLevel = new List<int>();
            var result = new List<int>();

            leftView(root, 0, visitedLevel, result);

            return result;
        }

        static void leftView(TreeNode currNode, int level, List<int> visitedLevel, List<int> result)
        {
            if (currNode != null)
            {
                if (!visitedLevel.Contains(level))
                {
                    visitedLevel.Add(level);
                    result.Add(currNode.val);
                }
                level++;
                leftView(currNode.left, level, visitedLevel, result);
                leftView(currNode.right, level, visitedLevel, result);
            }
        }
    }
}
