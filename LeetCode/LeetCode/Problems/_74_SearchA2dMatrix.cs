using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _74_SearchA2dMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            return mySolution(matrix, target);
        }

        bool mySolution(int[][] matrix, int target)
        {
            foreach (var i in matrix)
            {
                foreach (var j in i)
                {
                    if (j == target)
                    {
                        return true;
                    }
                    else if (j > target)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

    }
}
