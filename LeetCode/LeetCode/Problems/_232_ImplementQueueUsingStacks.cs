using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _232_ImplementQueueUsingStacks
    {
        public class MyQueue
        {
            Stack<int> stack1;
            Stack<int> stack2;

            /** Initialize your data structure here. */
            public MyQueue()
            {
                stack1 = new Stack<int>();
                stack2 = new Stack<int>();
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                stack1.Push(x);
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                exchange();

                return stack2.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                exchange();

                return stack2.Peek();
            }

            void exchange()
            {
                if (stack2.Count == 0 && stack1.Count != 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return stack1.Count == 0 && stack2.Count == 0;
            }


        }

        /**
         * Your MyQueue object will be instantiated and called as such:
         * MyQueue obj = new MyQueue();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Peek();
         * bool param_4 = obj.Empty();
         */
    }
}
