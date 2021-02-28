using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    public class _22_GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            return mySolution(n);
        }

        IList<string> mySolution(int n)
        {
            List<string> result = new List<string>()
            {
                "()"
            };

            List<string> temp = new List<string>();

            for(int i = 1; i < n; i++)
            {
                while (result.Count > 0)
                {
                    string str = result[0];

                    for(int j = 0; j < str.Length; j++)
                    {
                        temp.Add(str.Insert(j, "()"));
                    }
                    temp.Add(str + "()");

                    result.RemoveAt(0);
                }
                result.AddRange(temp);
                temp.Clear();
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach(var item in result)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, item);
                }
            }
            result = dic.Keys.ToList();
            return result;
        }
    }
}
