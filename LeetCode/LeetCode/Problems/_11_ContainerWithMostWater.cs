using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _11_ContainerWithMostWater
    {

        public int MaxArea(int[] height)
        {
            return bestSolution(height);
        }

        int mySolution(int[] height)
        {
            int result = 0;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = height.Length - 1; j > i; j--)
                {
                    if (height[j] >= height[i])
                    {
                        if (result < height[i] * (j - i))
                        {
                            result = height[i] * (j - i);
                        }

                        break;
                    }
                    else
                    {

                        if (result < height[j] * (j - i))
                        {
                            result = height[j] * (j - i);
                        }
                    }
                }
            }

            return result;
        }

        int bestSolution(int[] height)
        {
            int i = 0, j = height.Length - 1;
            int result = j * (height[i] > height[j] ? height[j] : height[i]);

            while (i < j)
            {
                if (height[i] >= height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }

                if ((j - i) * (height[i] > height[j] ? height[j] : height[i]) > result)
                {
                    result = (j - i) * (height[i] > height[j] ? height[j] : height[i]);
                }
            }

            return result;
        }
    }
}
