using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class BinaryTreeVerticalSum
    {
        public static void SolveIt(TreeNode root)
        {
            var totalPerVIndex = new Dictionary<int, int>();

            CalculateVerticalSum(root, 0, totalPerVIndex);
            string s = "";
            foreach (var kvp in totalPerVIndex.OrderBy(x => x.Key))
            {
                s += kvp.Value + ", ";
            }

            Console.WriteLine("Vertical sum of tree is [{0}]", s.Substring(0, s.Length - 2));
        }

        static void CalculateVerticalSum(TreeNode currNode, int index, Dictionary<int, int> totalPerVIndex)
        {
            if (currNode != null)
            {
                if (totalPerVIndex.ContainsKey(index))
                {
                    totalPerVIndex[index] += currNode.val;
                }
                else
                {
                    totalPerVIndex[index] = currNode.val;
                }

                CalculateVerticalSum(currNode.left, index - 1, totalPerVIndex);
                CalculateVerticalSum(currNode.right, index + 1, totalPerVIndex);
            }
        }
    }
}
