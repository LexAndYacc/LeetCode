using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _456_132Pattern
    {
        public bool Find132pattern(int[] nums)
        {
            return bestSolution(nums);
        }

        bool bestSolution(int[] nums)
        {
            int n = nums.Length;
            Stack<int> candidateK = new Stack<int>();
            candidateK.Push(nums[n - 1]);
            int maxK = int.MinValue;

            for (int i = n - 2; i >= 0; --i)
            {
                if (nums[i] < maxK)
                {
                    return true;
                }
                while (candidateK.Count != 0 && nums[i] > candidateK.Peek())
                {
                    maxK = candidateK.Pop();
                }
                if (nums[i] > maxK)
                {
                    candidateK.Push(nums[i]);
                }
            }

            return false;
        }
    }
}
