﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class RightViewBinaryTree
    {
        #region Solution 1
        public static IList<int> SolveIt(TreeNode root)
        {
            var visitedLevel = new List<int>();
            var result = new List<int>();

            rightView(root, 0, visitedLevel, result);

            return result;
        }

        static void rightView(TreeNode currNode, int level, List<int> visitedLevel, List<int> result)
        {
            if (currNode != null)
            {
                if (!visitedLevel.Contains(level))
                {
                    visitedLevel.Add(level);
                    result.Add(currNode.val);
                }
                level++;
                rightView(currNode.right, level, visitedLevel, result);
                rightView(currNode.left, level, visitedLevel, result);
            }
        }
        #endregion

        #region Solution 2
        public static IList<int> SolveIt2(TreeNode root)
        {
            var result = new Dictionary<int, int>();

            rightView(root, 0, result);

            return result.Values.ToList();
        }

        static void rightView(TreeNode currNode, int level, Dictionary<int, int> result)
        {
            if (currNode != null)
            {
                if (!result.ContainsKey(level))
                {
                    result[level] = currNode.val;
                }
                level++;
                rightView(currNode.right, level, result);
                rightView(currNode.left, level, result);
            }
        }
        #endregion
    }
}
