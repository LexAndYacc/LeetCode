using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _20_ValidParentheses
    {
        public bool IsValid(string s)
        {
            return bestSolution(s);
        }

        bool mySolution(string s)
        {
            bool result = true;
            if (s.Length == 0)
            {
                return result;
            }

            if (s.Length % 2 == 0)
            {
                Dictionary<char, char> dic = new Dictionary<char, char>()
                {
                    {'(',')' },
                    {'[',']' },
                    {'{','}' }
                };


                Stack<char> stack1 = new Stack<char>();
                Stack<char> stack2 = new Stack<char>();
                foreach (var item in s)
                {
                    stack1.Push(item);
                }

                while (stack1.Count > 0)
                {
                    if (stack2.Count > 0)
                    {
                        if (dic.ContainsKey(stack1.Peek()))
                        {
                            if (dic[stack1.Peek()] == stack2.Peek())
                            {
                                stack1.Pop();
                                stack2.Pop();
                                continue;
                            }
                        }
                    }

                    stack2.Push(stack1.Pop());
                    if (stack1.Count == 0)
                    {
                        result = false;
                        break;
                    }
                    if (dic.ContainsKey(stack1.Peek()))
                    {
                        if (dic[stack1.Peek()] == stack2.Peek())
                        {
                            stack1.Pop();
                            stack2.Pop();
                        }
                    }
                }
                if (stack2.Count != 0)
                {
                    result = false;
                }

            }
            else
            {
                result = false;
            }

            return result;
        }

        bool bestSolution(string s)
        {
            if (s.Length == 0)
                return true;
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else if (stack.Count == 0 || c != stack.Pop())
                    return false;
            }
            if (stack.Count == 0)
                return true;
            return false;
        }
    }
}
