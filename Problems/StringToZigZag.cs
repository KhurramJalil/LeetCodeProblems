using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    class Point
    {
        public int X;
        public int Y;
    }

    internal class StringToZigZag
    {
        static Point getPointFromXY(int pX, int pY, int numRows)
        {
            //if this is the last row
            if (pY == numRows - 1)
            {
                //increase pX and decreas pY
                return new Point { X = pX + 1, Y = pY - 1 };
            }
            else if (pY == 0)
            {
                //this is the first row so increase Y
                return new Point { X = pX, Y = pY + 1 };
            }
            else
            {
                //if we are going zing (downward)
                if ((pX % (numRows - 1)) == 0)
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

        public static string SolveIt(string s, int numRows)
        {
            if (numRows == 1) return s;
            if (s.Length <= numRows) numRows = s.Length - 1;

            Point p = new Point { X = 0, Y = 0 };

            string[] grid = new string[numRows];

            for (int i = 0; i < s.Length; i++)
            {
                grid[p.Y] += s[i];
                p = getPointFromXY(p.X, p.Y, numRows);
            }

            return String.Join("", grid);
        }
    }
}
