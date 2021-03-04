using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _354_RussianDollEnvelopes
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            return mySolution(envelopes);
        }

        int mySolution(int[][] envelopes)
        {
            Array.Sort(envelopes, (x, y) =>
            {
                if (x[0] != y[0])
                {
                    return x[0] - y[0];
                }
                else
                {
                    return y[1] - x[1];
                }
            });

            int[] nums = new int[envelopes.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = envelopes[i][1];
            }

            return longestIncreasingSubsequence(nums);
        }

        int longestIncreasingSubsequence(int[] nums)
        {
            int len = 1, n = nums.Length;
            if (n == 0)
            {
                return 0;
            }
            int[] d = new int[n + 1];
            d[len] = nums[0];
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] > d[len])
                {
                    d[++len] = nums[i];
                }
                else
                {
                    int l = 1, r = len, pos = 0;
                    while (l <= r)
                    {
                        int mid = (l + r) >> 1;
                        if (d[mid] < nums[i])
                        {
                            pos = mid;
                            l = mid + 1;
                        }
                        else
                        {
                            r = mid - 1;
                        }
                    }
                    d[pos + 1] = nums[i];
                }
            }
            return len;
        }
    }
}
