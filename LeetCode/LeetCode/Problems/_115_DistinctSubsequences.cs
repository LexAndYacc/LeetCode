using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _115_DistinctSubsequences
    {
        public int NumDistinct(string s, string t)
        {
            return mySolution(s, t);
        }

        int mySolution(string s,string t)
        {
            int m = s.Length, n = t.Length;
            if (m < n)
            {
                return 0;
            }
            int[][] dp = new int[m + 1][];
            for (int i = 0; i <= m; i++)
            {
                dp[i] = new int[n + 1];
                dp[i][n] = 1;
            }
            for (int i = m - 1; i >= 0; i--)
            {
                char sChar = s[i];
                for (int j = n - 1; j >= 0; j--)
                {
                    char tChar = t[j];
                    if (sChar == tChar)
                    {
                        dp[i][j] = dp[i + 1][j + 1] + dp[i + 1][j];
                    }
                    else
                    {
                        dp[i][j] = dp[i + 1][j];
                    }
                }
            }
            return dp[0][0];
        }
    }
}
