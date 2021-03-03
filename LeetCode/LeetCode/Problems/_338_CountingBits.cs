using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _338_CountingBits
    {
        public int[] CountBits(int num)
        {
            return mySolution(num);
        }

        int[] mySolution(int num)
        {
            if(num == 0)
            {
                return new int[] { 0 };
            }
            else if (num == 1)
            {
                return new int[] { 0, 1 };
            }

            int[] result = new int[num + 1];
            result[0] = 0;
            result[1] = 1;

            int flag = 2;
            for (int i = 0; i <= num; i++)
            {
                if (i < 2)
                {
                    continue;
                }

                result[i] = result[i - flag] + 1;

                if (i + 1 >= flag * 2)
                {
                    flag *= 2;
                }
            }
            return result;
        }

        int[] bestSolution(int num)
        {
            int[] bits = new int[num + 1];
            for (int i = 1; i <= num; i++)
            {
                bits[i] = bits[i >> 1] + (i & 1);
            }
            return bits;
        }
        int[] bestSolution2(int num)
        {
            int[] bits = new int[num + 1];
            for (int i = 1; i <= num; i++)
            {
                bits[i] = bits[i & (i - 1)] + 1;
            }
            return bits;
        }
    }
}
