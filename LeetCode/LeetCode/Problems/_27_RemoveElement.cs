using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            return mySolution(nums, val);
        }

        int mySolution(int[] nums,int val)
        {
            int left = 0;
            int right = nums.Length;
            while (left < right)
            {
                if (nums[left] == val)
                {
                    nums[left] = nums[right - 1];
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return left;
        }
    }
}