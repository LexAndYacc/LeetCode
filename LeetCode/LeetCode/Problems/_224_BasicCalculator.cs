using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _224_BasicCalculator
    {
        public int Calculate(string s)
        {
            return mySolution(s);
        }

        int mySolution(string s)
        {
            int flag = 1;
            int result = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }
                else if (s[i] == '(')
                {
                    stack.Push(flag);
                }
                else if (s[i] == ')')
                {
                    stack.Pop();
                }
                else if (s[i] == '+')
                {
                    flag = stack.Peek();
                }
                else if (s[i] == '-')
                {
                    flag = -stack.Peek();
                }
                else
                {
                    int number = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        number = number * 10 + Convert.ToInt32(s[i].ToString());
                        i++;
                    }
                    i--;
                    result += number * flag;
                }
            }

            return result;
        }
    }
}
