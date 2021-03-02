using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _304_RangeSumQuery2dImmutable
    {
        public class NumMatrix
        {
            int[][] matrixs;

            public NumMatrix(int[][] matrix)
            {
                if (matrix.Length == 0)
                {
                    matrixs = new int[0][];
                    return;
                }
                else if (matrix[0].Length == 0)
                {
                    matrixs = new int[matrix.Length + 1][];
                    return;
                }

                matrixs = new int[matrix.Length + 1][];
                for (int i = 0; i < matrixs.Length; i++)
                {
                    matrixs[i] = new int[matrix[0].Length + 1];
                }

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        matrixs[i + 1][j + 1] = matrixs[i][j + 1] + (matrixs[i + 1][j] - matrixs[i][j]) + matrix[i][j];
                    }
                }


            }


            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                return matrixs[row2 + 1][col2 + 1] - matrixs[row1][col2 + 1] - matrixs[row2 + 1][col1] + matrixs[row1][col1];
            }

        }
    }


}
