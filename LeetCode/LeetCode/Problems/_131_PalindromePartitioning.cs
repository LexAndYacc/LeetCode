using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _131_PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            return mySolution(s);
        }

        IList<IList<string>> mySolution(string s)
        {
            List<IList<string>> results = new List<IList<string>>();
            getPalindrome(results, new List<string>(), s, 0);
            if (isPalindrome(s, 0, s.Length - 1))
            {
                results.Add(new List<string>() { s });
            }
            return results;
        }

        void getPalindrome(List<IList<string>> results, List<string> result, string s, int start)
        {
            for (int i = start; i < s.Length - 1; i++)
            {
                if (isPalindrome(s, start, i))
                {

                    result.Add(s.Substring(start, i - start + 1));

                    if (isPalindrome(s, i + 1, s.Length - 1))
                    {
                        List<string> temp = new List<string>();
                        temp.AddRange(result);
                        temp.Add(s.Substring(i + 1));
                        results.Add(temp);
                    }
                    getPalindrome(results, result, s, i + 1);
                    result.RemoveAt(result.Count - 1);
                }
            }

        }

        bool isPalindrome(string s, int start, int end)
        {
            while (start <= end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }

                start++;
                end--;
            }
            return true;
        }
    }
}
