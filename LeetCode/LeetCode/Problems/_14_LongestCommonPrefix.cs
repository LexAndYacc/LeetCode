using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            return mySolution(strs);
        }

        string mySolution(string[] strs)
        {
            string result = "";
            char ch = '\0';

            if (strs.Length == 0)
            {
                return "";
            }

            for (int i = 0; i < strs[0].Length; i++)
            {
                ch = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length <=i || ch != strs[j][i])
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != -1)
                {
                    result += strs[0][i];
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
