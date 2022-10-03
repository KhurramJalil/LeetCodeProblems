// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");
#region Two Sum
Console.WriteLine("<=========== Two Sum =======>");
var arr1 = new int[] { 2, 2, 2, 3, 3, 7, 11, 15 };
Console.WriteLine("\nFor int array {0}", string.Join(",", arr1));
Console.WriteLine("Index of numbers with sum 9 = {0}", String.Join(",", TwoSum(arr1, 9)));
Console.WriteLine("Index of numbers with sum 13 = {0}", String.Join(",", TwoSum(arr1, 13)));
Console.WriteLine("Index of numbers with sum 18 = {0}", String.Join(",", TwoSum(arr1, 18)));
Console.WriteLine("Index of numbers with sum 17 = {0}", String.Join(",", TwoSum(arr1, 17)));

arr1 = new int[] { 3, 2, 1, 4 };
Console.WriteLine("\nFor int array {0}", string.Join(",", arr1));
Console.WriteLine("Index of numbers with sum 6 = {0}", String.Join(",", TwoSum(arr1, 6)));

arr1 = new int[] { 3, 3 };
Console.WriteLine("\nFor int array {0}", string.Join(",", arr1));
Console.WriteLine("Index of numbers with sum 6 = {0}", String.Join(",", TwoSum(arr1, 6)));

#endregion

#region Longest Unique Substring Length
Console.WriteLine("\n\n<=========== Longest Unique Substring Length =======>");
Console.WriteLine("\nFor howareyou? the longest non-repeating substring is {0}", LongestUniqueSubstringLength("howareyou?"));
Console.WriteLine("For thisshouldbegood the longest non-repeating substring is {0}", LongestUniqueSubstringLength("thisshouldbegood"));
Console.WriteLine("For hardtoguess the longest non-repeating substring is {0}", LongestUniqueSubstringLength("hardtoguess"));
Console.WriteLine("For realuniq the longest non-repeating substring is {0}", LongestUniqueSubstringLength("realuniq"));
Console.WriteLine("For abcabcbb the longest non-repeating substring is {0}", LongestUniqueSubstringLength("abcabcbb"));
Console.WriteLine("For bbbb the longest non-repeating substring is {0}", LongestUniqueSubstringLength("bbbb"));
Console.WriteLine("For pwwkew the longest non-repeating substring is {0}", LongestUniqueSubstringLength("pwwkew"));
Console.WriteLine("For dvdf the longest non-repeating substring is {0}", LongestUniqueSubstringLength("dvdf"));
#endregion

#region String Reverse Recursive
Console.WriteLine("\n\n<=========== String Reverse Recursive =======>");
Console.Write("Reverse of 'How are you?' is: ");
RecursivelyReverse("How are you?");
#endregion

#region Integer Reverse
Console.WriteLine("\n\n<=========== Integer Reverse =======>");
Console.WriteLine("Reverse of '123654654' is: {0}", ReverseInteger(123654654));
Console.WriteLine("Reverse of '-1236549999' is: {0}", ReverseInteger(-1236549999));
Console.WriteLine("Reverse of '-123' is: {0}", ReverseInteger(-123));
Console.WriteLine("Reverse of '1463847412' is: {0}", ReverseInteger(1463847412));
#endregion

#region Longest Palindrome Substring
Console.WriteLine("\n\n<=========== Longest Palindrome Substring =======>");
Console.WriteLine("Longest Panlidrome Substring in 'racecar' is: {0}", LongestPalindromeSubstring("racecar"));
Console.WriteLine("Longest Panlidrome Substring in 'cbbd' is: {0}", LongestPalindromeSubstring("cbbd"));
Console.WriteLine("Longest Panlidrome Substring in 'babad' is: {0}", LongestPalindromeSubstring("babad"));
#endregion

#region Median of 2 sorted arrays
Console.WriteLine("\n\n<=========== Median of 2 sorted arrays =======>");
Console.WriteLine("For input nums1 = [1,3], nums2 = [2], the median is: {0}", FindMedianSortedArrays(new int[] {1, 3}, new int[] {2}));
Console.WriteLine("For input nums1 = [1,2], nums2 = [3,4], the median is: {0}", FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }));
#endregion

#region Binary Search
Console.WriteLine("\n\n<=========== Binary Search =======>");
int result = FindItemIndexInArray(new int[] { 2, 3, 4, 10, 40 }, 10);
Console.WriteLine("Finding number 10 in array { 2, 3, 4, 10, 40 }");
if (result == -1)
    Console.WriteLine("Element not found");
else
    Console.WriteLine("Element found at index {0}",result);
#endregion

#region Atoi
Console.WriteLine("\n\n<=========== Atoi =======>");
Console.WriteLine("Atoi for '    -42' = "+Atoi("   -42"));
Console.WriteLine("Atoi for ' -123' = " + Atoi(" -123"));
Console.WriteLine("Atoi for ' +123' = " + Atoi(" +123"));
Console.WriteLine("Atoi for '    +-123' = " + Atoi("   +-123"));
Console.WriteLine("Atoi for ' 1234withwords' = " + Atoi(" 1234withwords"));
Console.WriteLine("Atoi for ' before123word' = " + Atoi("  before123word"));
#endregion

#region Atoi
Console.WriteLine("\n\n<=========== Number Palindrome =======>");
Console.WriteLine("Is -121 palindrome? " + (IsPalindrome(-121) ? "Yes":"No"));
#endregion

#region Trapping Rain Water
Console.WriteLine("\n\n<=========== Trapping Rain Water =======>");
Console.WriteLine("Trapped rain water in array [0,1,0,2,1,0,1,3,2,1,2,1] = " + Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}));
Console.WriteLine("Trapped rain water in array [4,2,0,3,2,5] = " + Trap(new int[] { 4, 2, 0, 3, 2, 5 }));
Console.WriteLine("Trapped rain water in array [3, 0, 2, 0, 4] = " + Trap(new int[] { 3, 0, 2, 0, 4 }));
Console.WriteLine("Trapped rain water in array [2,0,2] = " + Trap(new int[] { 2, 0, 2 }));
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
TreeVerticalSum(root);
#endregion

#region Trapping Rain Water
Console.WriteLine("\n\n<=========== Convert String to ZigZag =======>");
Console.WriteLine("Zigzag for PAYPALISHIRING in 4 rows is = " + ConvertToZigZag("PAYPALISHIRING", 4));
#endregion

int[] TwoSum(int[] nums, int target)
{
    var map = new Dictionary<int, int>();

    for(int i= 0; i<nums.Length; i++)
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
    return new int[] {-1, -1};
}

int LongestUniqueSubstringLength(string s)
{
    var test = string.Empty;
    int maxLength = 0;

    for (int i = 0; i < s.Length; i++)
    {
        var currChar = s[i];

        // If string already contains the character then substring after repeating character
        if (test.Contains(currChar))
        {
            test = test.Substring(test.IndexOf(currChar) + 1);
        }
        test = test + currChar.ToString();
        maxLength = Math.Max(test.Length, maxLength);
    }
    return maxLength;
}

void RecursivelyReverse(string s)
{
    if(!string.IsNullOrEmpty(s))
        RecursivelyReverse(s.Substring(1));
    //Either of the following will work
    Console.Write(s.FirstOrDefault());
    //OR
    //Console.Write(s.Substring(0, 1));
}

int ReverseInteger(int x)
{
    int reverse = 0;

    while(x != 0)
    {
        int pop = x % 10;
        x /= 10;

        if ((reverse > (int.MaxValue / 10) || reverse == int.MaxValue/10 && x > 7) || (reverse < (int.MinValue / 10) || reverse == (int.MinValue / 10) && x < -8))
        {
            reverse = 0;
            break;
        }
        reverse = reverse * 10 + pop;
    }
    return reverse;
}

string LongestPalindromeSubstring(string s)
{
    int length = 0, startIndex = 0;
    for(int i= 0; i< s.Length; i++)
    {
        CheckFromMiddle(s, i, i, ref length, ref startIndex);
        CheckFromMiddle(s, i, i + 1, ref length, ref startIndex);
    }
    return s.Substring(startIndex+1, length);
}

void CheckFromMiddle(string s, int i, int j, ref int length, ref int startIndex)
{
    while(i >= 0 && j < s.Length && s[i] == s[j])
    {
        i--;
        j++;
    }

    if(j-i-1 > length)
    {
        length = j - i - 1;
        startIndex = i;
    }
}

double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int m = nums1.Length,
        n= nums2.Length,
        i=0, j=0, k=0;

    int[] merged = new int[m + n];

    while(i < m && j < n)
    {
        if(nums1[i] < nums2[j])
            merged[k++] = nums1[i++];
        else
            merged[k++] = nums2[j++];
    }

    while(i < m)
        merged[k++] = nums1[i++];

    while(j < n)
        merged[k++] = nums2[j++];

    int medianIndex = merged.Length / 2;

    if (merged.Length % 2 > 0)
    {
        return merged[medianIndex];
    }
    else
    {
        return (merged[medianIndex -1] + merged[medianIndex]) / 2.0;
    }
}

int FindItemIndexInArray(int[] nums, int target)
{
    return BinarySearch(nums, 0, nums.Length-1, target);
}

int BinarySearch(int[] nums, int low, int high, int target)
{
    int mid = (low + high) / 2;
    
    while(low < high)
    {
        if (target == nums[mid]) {
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

int Atoi(string s)
{
    int sign = 1,
        result = 0,
        k = 0;
    if (!string.IsNullOrEmpty(s))
    {
        while (s[k] == ' ') k++;

        if (s[k] == '-' || s[k] == '+')
        {
            sign = s[k] == '-' ? -1 : 1;
            k++;
        }

        while (k < s.Length && s[k] >= '0' && s[k] <= '9')
        {
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && s[k] - '0' > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }
            result = result * 10 + s[k++] - '0';
        }
    }
    return result * sign;
}

bool IsPalindrome(int x)
{
    int reverse = 0,
        temp = x;

    while (temp > 0)
    {
        int pop = temp % 10;
        temp /= 10;

        if ((reverse > (int.MaxValue / 10) || reverse == int.MaxValue / 10 && x > 7) || (reverse < (int.MinValue / 10) || reverse == (int.MinValue / 10) && x < -8))
        {
            reverse = 0;
            break;
        }
        reverse = reverse * 10 + pop;
    }
    return reverse == x && x >= 0;
}

int Trap(int[] height)
{
    int left = 0,
        right = height.Length - 1,
        lMax = 0,
        rMax = 0,
        result=0;

    while(left <= right)
    {
        if(rMax <= lMax)
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

void CalculateVerticalSum(TreeNode currNode, int index, Dictionary<int, int> totalPerVIndex)
{
    if(currNode != null)
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

void TreeVerticalSum(TreeNode root)
{
    var totalPerVIndex = new Dictionary<int, int>();

    CalculateVerticalSum(root, 0, totalPerVIndex);
    string s = "";
    foreach(var kvp in totalPerVIndex.OrderBy(x=> x.Key))
    {
        s += kvp.Value + ", ";
    }

    Console.WriteLine("Vertical sum of tree is [{0}]", s.Substring(0, s.Length-2));
}

//[0,-1,1,-2,0,0]
//[3,1,4,0,2,2]
IList<IList<int>> VerticalTraversal(TreeNode root)
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

void FillAllInSameVIndex(TreeNode currNode, int index, SortedDictionary<int, List<int>> result)
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

Point getPointFromXY(int pX, int pY, int numRows)
{
    //if this is the last row
    if(pY == numRows -1)
    {
        //increase pX and decreas pY
        return new Point { X = pX + 1, Y = pY - 1 };
    }
    else if(pY == 0)
    {
        //this is the first row so increase Y
        return new Point { X = pX, Y = pY + 1 };
    }
    else
    {
        //if we are going zing (downward)
        if((pX % (numRows-1)) == 0)
        {
            //increase pY
            return new Point { X = pX, Y = pY + 1 };
        }
        else
        {
            //We are going zag (upward) so increase pX and decrease pY
            return new Point { X = pX + 1, Y = pY - 1 };
        }
    }
}

string ConvertToZigZag(string s, int numRows)
{
    if (numRows == 1) return s;
    if (s.Length <= numRows) numRows = s.Length - 1;

    Point p = new Point { X = 0, Y = 0 };

    string[] grid = new string[numRows];

    for(int i=0; i<s.Length; i++)
    {
        grid[p.Y] += s[i];
        p = getPointFromXY(p.X, p.Y, numRows);
    }

    return String.Join("", grid);
}
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

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}