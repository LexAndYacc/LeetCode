using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _227_BasicCalculatorII
    {
        public int Calculate(string s)
        {
            return mySolution(s);
        }

        int mySolution(string s)
        {
            int result = 0;
            int flag = 1;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }
                else if (s[i] == '*')
                {
                    result = stack.Pop();
                    int number = 0;
                    while (!char.IsDigit(s[i]))
                    {
                        i++;
                    }
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        number = number * 10 + Convert.ToInt32(s[i].ToString());
                        i++;
                    }
                    i--;
                    stack.Push(result * number);
                    result = 0;
                }
                else if (s[i] == '/')
                {
                    result = stack.Pop();
                    int number = 0;
                    while (!char.IsDigit(s[i]))
                    {
                        i++;
                    }
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        number = number * 10 + Convert.ToInt32(s[i].ToString());
                        i++;
                    }
                    i--;
                    stack.Push(result / number);
                    result = 0;
                }
                else if (s[i] == '+')
                {
                    flag = 1;
                }
                else if (s[i] == '-')
                {
                    flag = -1;
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
                    stack.Push(number * flag);
                }
            }

            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;
        }
    }
}
