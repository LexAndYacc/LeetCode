using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _54_SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            return mySolution(matrix);
        }

        IList<int> mySolution(int[][] matrix)
        {
            const int FLAG = 666;
            IList<int> result = new List<int>();
            int direction = 0;
            int i = 0, j = 0, iMin = 0, jMin = 0, iMax = matrix.Length - 1, jMax = matrix[0].Length - 1;
            result.Add(matrix[0][0]);
            matrix[0][0] = FLAG;
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
                if(matrix[i][j] == FLAG)
                {
                    break;
                }
                result.Add(matrix[i][j]); 
                matrix[i][j] = FLAG;
            }

            return result;
        }
    }
}
