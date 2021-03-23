using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _341_FlattenNestedListIterator
    {
        public class NestedIterator
        {
            Stack<(int, IList<NestedInteger>)> stack;

            public NestedIterator(IList<NestedInteger> nestedList)
            {
                stack = new Stack<(int, IList<NestedInteger>)>();
                stack.Push((0, nestedList));
            }

            public bool HasNext()
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var top = stack.Pop();
                int num = top.Item1;
                IList<NestedInteger> list = top.Item2;

                if (list.Count == num)
                {
                    return HasNext();
                }

                if (list[num].IsInteger())
                {
                    stack.Push(top);
                    return true;
                }
                else
                {
                    top.Item1++;
                    stack.Push(top);
                    stack.Push((0, list[num].GetList()));
                    return HasNext();
                }

            }

            public int Next()
            {
                var top = stack.Pop();
                int num = top.Item1;
                IList<NestedInteger> list = top.Item2;
                stack.Push((num + 1, list));

                return list[num].GetInteger();
            }
        }

        public interface NestedInteger
        {

            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            bool IsInteger();

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            int GetInteger();

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            IList<NestedInteger> GetList();
        }
    }
}
