using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _191_NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            return mySolution(n);
        }

        int mySolution(uint n)
        {
            int result = 0;

            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    result++;
                }
                n = n >> 1;
            }

            return result;
        }
        int bestSolution(uint n)
        {
            int ret = 0;
            while (n != 0)
            {
                n &= n - 1;
                ret++;
            }
            return ret;
        }
    }
}
