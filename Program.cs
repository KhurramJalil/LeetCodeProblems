// See https://aka.ms/new-console-template for more information
using LeetCodeProblems.Problems;

Console.WriteLine("Hello, World!");

#region Two Sum
Console.WriteLine("<=========== Two Sum =======>");
var arr1 = new int[] { 2, 2, 2, 3, 3, 7, 11, 15 };
Console.WriteLine("\nFor int array {0}", string.Join(",", arr1));
Console.WriteLine("Index of numbers with sum 9 = {0}", String.Join(",", TwoSum.SolveIt(arr1, 9)));
Console.WriteLine("Index of numbers with sum 13 = {0}", String.Join(",", TwoSum.SolveIt(arr1, 13)));
Console.WriteLine("Index of numbers with sum 18 = {0}", String.Join(",", TwoSum.SolveIt(arr1, 18)));
Console.WriteLine("Index of numbers with sum 17 = {0}", String.Join(",", TwoSum.SolveIt(arr1, 17)));

arr1 = new int[] { 3, 2, 1, 4 };
Console.WriteLine("\nFor int array {0}", string.Join(",", arr1));
Console.WriteLine("Index of numbers with sum 6 = {0}", String.Join(",", TwoSum.SolveIt(arr1, 6)));

arr1 = new int[] { 3, 3 };
Console.WriteLine("\nFor int array {0}", string.Join(",", arr1));
Console.WriteLine("Index of numbers with sum 6 = {0}", String.Join(",", TwoSum.SolveIt(arr1, 6)));

#endregion

#region Longest Unique Substring Length
Console.WriteLine("\n\n<=========== Longest Unique Substring Length =======>");
Console.WriteLine("\nFor howareyou? the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("howareyou?"));
Console.WriteLine("For thisshouldbegood the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("thisshouldbegood"));
Console.WriteLine("For hardtoguess the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("hardtoguess"));
Console.WriteLine("For realuniq the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("realuniq"));
Console.WriteLine("For abcabcbb the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("abcabcbb"));
Console.WriteLine("For bbbb the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("bbbb"));
Console.WriteLine("For pwwkew the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("pwwkew"));
Console.WriteLine("For dvdf the longest unique substring is {0}", LongestUniqueSubstringLength.SolveIt("dvdf"));
#endregion

#region String Reverse Recursive
Console.WriteLine("\n\n<=========== String Reverse Recursive =======>");
Console.Write("Reverse of 'How are you?' is: ");
RecursivelyReverseString.SolveIt("How are you?");
#endregion

#region Integer Reverse
Console.WriteLine("\n\n<=========== Integer Reverse =======>");
Console.WriteLine("Reverse of '123654654' is: {0}", IntegerReverse.SolveIt(123654654));
Console.WriteLine("Reverse of '-1236549999' is: {0}", IntegerReverse.SolveIt(-1236549999));
Console.WriteLine("Reverse of '-123' is: {0}", IntegerReverse.SolveIt(-123));
Console.WriteLine("Reverse of '1463847412' is: {0}", IntegerReverse.SolveIt(1463847412));
#endregion

#region Longest Palindrome Substring
Console.WriteLine("\n\n<=========== Longest Palindrome Substring =======>");
Console.WriteLine("Longest Panlidrome Substring in 'racecar' is: {0}", LongestPalindromeSubstring.SolveIt("racecar"));
Console.WriteLine("Longest Panlidrome Substring in 'cbbd' is: {0}", LongestPalindromeSubstring.SolveIt("cbbd"));
Console.WriteLine("Longest Panlidrome Substring in 'babad' is: {0}", LongestPalindromeSubstring.SolveIt("babad"));
#endregion

#region Median of 2 sorted arrays
Console.WriteLine("\n\n<=========== Median of 2 sorted arrays =======>");
Console.WriteLine("For input nums1 = [1,3], nums2 = [2], the median is: {0}", MedianSortedArrays.SolveIt(new int[] {1, 3}, new int[] {2}));
Console.WriteLine("For input nums1 = [1,2], nums2 = [3,4], the median is: {0}", MedianSortedArrays.SolveIt(new int[] { 1, 2 }, new int[] { 3, 4 }));
#endregion

#region Binary Search in Array
Console.WriteLine("\n\n<=========== Binary Search in Array =======>");
int result = BinarySearchArray.SolveIt(new int[] { 2, 3, 4, 10, 40 }, 10);
Console.WriteLine("Finding number 10 in array { 2, 3, 4, 10, 40 }");
if (result == -1)
    Console.WriteLine("Element not found");
else
    Console.WriteLine("Element found at index {0}",result);
#endregion

#region Atoi
Console.WriteLine("\n\n<=========== Atoi =======>");
Console.WriteLine("Atoi for '    -42' = "+Atoi.SolveIt("   -42"));
Console.WriteLine("Atoi for ' -123' = " + Atoi.SolveIt(" -123"));
Console.WriteLine("Atoi for ' +123' = " + Atoi.SolveIt(" +123"));
Console.WriteLine("Atoi for '    +-123' = " + Atoi.SolveIt("   +-123"));
Console.WriteLine("Atoi for ' 1234withwords' = " + Atoi.SolveIt(" 1234withwords"));
Console.WriteLine("Atoi for ' before123word' = " + Atoi.SolveIt("  before123word"));
#endregion

#region Palindrome Number
Console.WriteLine("\n\n<=========== Number Palindrome =======>");
Console.WriteLine("Is -121 palindrome? " + (PalindromeNumber.SolveIt(-121) ? "Yes":"No"));
#endregion

#region Trapping Rain Water
Console.WriteLine("\n\n<=========== Trapping Rain Water =======>");
Console.WriteLine("Trapped rain water in array [0,1,0,2,1,0,1,3,2,1,2,1] = " + TrappingRainWater.SolveIt(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}));
Console.WriteLine("Trapped rain water in array [4,2,0,3,2,5] = " + TrappingRainWater.SolveIt(new int[] { 4, 2, 0, 3, 2, 5 }));
Console.WriteLine("Trapped rain water in array [3, 0, 2, 0, 4] = " + TrappingRainWater.SolveIt(new int[] { 3, 0, 2, 0, 4 }));
Console.WriteLine("Trapped rain water in array [2,0,2] = " + TrappingRainWater.SolveIt(new int[] { 2, 0, 2 }));
#endregion

#region Vertical Sum of Binary Tree
TreeNode root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
root.left.left =new TreeNode(4);
root.left.right = new TreeNode(5);
root.right.left=new TreeNode(6);
root.right.right=new TreeNode(7);
Console.WriteLine("\n\n<=========== Vertical Sum of Binary Tree =======>");
BinaryTreeVerticalSum.SolveIt(root);
#endregion

#region Convert String to ZigZag Characters
Console.WriteLine("\n\n<=========== Convert String to ZigZag Characters =======>");
Console.WriteLine("Zigzag for PAYPALISHIRING in 4 rows is = " + StringToZigZag.SolveIt("PAYPALISHIRING", 4));
#endregion

public class TreeNode
{
    public int val;
    public TreeNode? left, right;

    public TreeNode(int val, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

