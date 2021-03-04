using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _300_LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            return bestSolution(nums);
        }

        int mySolution(int[] nums)
        {
            int result = 1;
            int[] cache = new int[nums.Length];
            cache[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                cache[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        if (cache[j] + 1 > cache[i])
                        {
                            cache[i] = cache[j] + 1;
                        }
                    }
                }
                if(cache[i] > result)
                {
                    result = cache[i];
                }
            }

            return result;
        }

        int bestSolution(int[] nums)
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
