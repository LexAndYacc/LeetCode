using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _132_PalindromePartitioningII
    {
        public int MinCut(string s)
        {
            return mySolution(s);
        }

        int mySolution(string s)
        {
            bool[][] g = new bool[s.Length][];
            for (int i = 0; i < s.Length; i++)
            {
                g[i] = new bool[s.Length];
                Array.Fill(g[i], true);
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    g[i][j] = s[i] == s[j] && g[i + 1][j - 1];
                }
            }
            
            int[] dp = new int[s.Length];
            Array.Fill(dp, int.MaxValue);

            for(int i = 0; i < s.Length; i++)
            {
                if (g[0][i])
                {
                    dp[i] = 0;
                }
                else
                {
                    for (int j = 0; j < i; ++j)
                    {
                        if (g[j + 1][i])
                        {
                            dp[i] = Math.Min(dp[i], dp[j] + 1);
                        }
                    }
                }
            }

            return dp[s.Length - 1];
        }


    }
}
