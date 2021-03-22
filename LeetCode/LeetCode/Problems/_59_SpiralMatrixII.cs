using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _59_SpiralMatrixII
    {
        public int[][] GenerateMatrix(int n)
        {
            return mySolution(n);
        }

        int [][] mySolution(int n)
        {
            int[][] result = new int[n][];
            for(int m = 0; m < n; m++)
            {
                result[m] = new int[n];
            }

            int direction = 0;
            int i = 0, j = 0, iMin = 0, jMin = 0, iMax = n - 1, jMax = n - 1, o = 1;
            result[0][0] = o++;
            while (true)
            {
                if (iMin > iMax || jMin > jMax)
                {
                    break;
                }

                if (direction == 0)
                {
                    j++;
                    if (j >= jMax)
                    {
                        direction = 1;
                        iMin++;
                        if (j != jMax)
                        {
                            j = jMax;
                            continue;
                        }
                    }
                }
                else if (direction == 1)
                {
                    i++;
                    if (i >= iMax)
                    {
                        direction = 2;
                        jMax--;
                    }
                }
                else if (direction == 2)
                {
                    j--;
                    if (j <= jMin)
                    {
                        direction = 3;
                        iMax--;
                    }
                }
                else if (direction == 3)
                {
                    i--;
                    if (i <= iMin)
                    {
                        direction = 0;
                        jMin++;
                    }
                }
                else
                {
                    throw new Exception();
                }
                if (result[i][j] != 0)
                {
                    break;
                }
                result[i][j] = o++;
            }


            return result;
        }
    }
}
