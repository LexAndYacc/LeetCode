using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _303_RangeSumQueryImmutable
    {
        public class NumArray
        {
            private int[] sums;
            public NumArray(int[] nums)
            {
                sums = new int[nums.Length + 1];
                for(int i = 0; i < nums.Length; i++)
                {
                    sums[i + 1] = sums[i] + nums[i];
                }
            }

            public int SumRange(int i, int j)
            {
                return sums[j + 1] - sums[i];
            }
        }
    }
}
