using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _1047_RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string S)
        {
            return bestSolution(S);
        }
        string mySolution(string S)
        {
            bool flag = true;
            while (S.Length > 1)
            {
                for (int i = 0; i < S.Length - 1; i++)
                {
                    flag = true;
                    if (S[i] == S[i + 1])
                    {
                        flag = false;
                        S = S.Remove(i, 2);
                        if (i != 0)
                        {
                            i -= 2;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }

                if (flag)
                {
                    break;
                }
            }
            return S;
        }

        string bestSolution(string S)
        {
            string result = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (result.Length == 0)
                {
                    result += S[i];
                }
                else
                {
                    if (result[result.Length - 1] == S[i])
                    {
                        result = result.Remove(result.Length - 1);
                    }
                    else
                    {
                        result += S[i];
                    }
                }
            }

            return result;
        }
    }
}
