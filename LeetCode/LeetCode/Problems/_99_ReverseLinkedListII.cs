using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _99_ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            return mySolution(head, left, right);
        }


        ListNode mySolution(ListNode head, int left, int right)
        {
            ListNode result = new ListNode(666);
            ListNode pResultEnd = result;
            if (left < right)
            {
                Stack<ListNode> stack = new Stack<ListNode>();
                int i = 1;
                while (i < left)
                {
                    pResultEnd.next = head;
                    pResultEnd = pResultEnd.next;
                    head = head.next;
                    i++;
                }
                while (i <= right)
                {
                    stack.Push(head);
                    head = head.next;
                    i++;
                }
                while (stack.Count > 0)
                {
                    pResultEnd.next = stack.Pop();
                    pResultEnd = pResultEnd.next;
                }
                pResultEnd.next = head;
            }
            else
            {
                result.next = head;
            }
            return result.next;
        }

        ListNode bestSolution(ListNode head, int left, int right)
        {
            ListNode dummyNode = new ListNode(-1);
            dummyNode.next = head;
            ListNode pre = dummyNode;
            for (int i = 0; i < left - 1; i++)
            {
                pre = pre.next;
            }
            ListNode cur = pre.next;
            ListNode next;
            for (int i = 0; i < right - left; i++)
            {
                next = cur.next;
                cur.next = next.next;
                next.next = pre.next;
                pre.next = next;
            }
            return dummyNode.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
