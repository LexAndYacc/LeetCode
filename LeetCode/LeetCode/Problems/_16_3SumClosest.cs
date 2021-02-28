using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _16_3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            return mySolution(nums, target);
        }

        int mySolution(int[] nums, int target)
        {
            if (nums == null || nums.Length < 3)
                return 0;

            int result = 0;

            int difference = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int n = j + 1; n < nums.Length; n++)
                    {
                        if (Math.Abs(nums[i] + nums[j] + nums[n] - target) < difference)
                        {
                            result = nums[i] + nums[j] + nums[n];
                            difference = Math.Abs(nums[i] + nums[j] + nums[n] - target);
                        }
                    }
                }
            }

            return result;
        }

        int bestSolution(int[] nums, int target)
        {
            int diff = int.MaxValue;
            int result = int.MaxValue;
            int length = nums.Length;
            //由小到大排序
            Array.Sort(nums);
            int ans = 0;
            for (int i = 0; i < length - 2; i++)
            {
                //避免重复项
                if ((i != 0) && (nums[i] == nums[i - 1]))
                {
                    continue;
                }
                int left = i + 1;
                int right = length - 1;
                int current = nums[i];
                while (right > left)
                {
                    int leftValue = nums[left];
                    int rightValue = nums[right];
                    ans = current + leftValue + rightValue;
                    int temp = int.MaxValue;
                    //等于目标，直接返回
                    if (ans == target)
                    {
                        return ans;
                    }
                    //目前的和大于目标，调右指针才会减少和
                    else if (ans > target)
                    {
                        //目前和和目标的差
                        temp = ans - target;
                        //避免重复项
                        while (right > left && nums[--right] == rightValue) { }
                    }
                    //目前的和大于目标，调左指针才会增加和
                    else
                    {
                        //目前和和目标的差
                        temp = target - ans;
                        //避免重复项
                        while (right > left && nums[++left] == leftValue) { }
                    }
                    //如果目前的和 比 之前的和 更接近目标
                    if (temp < diff)
                    {
                        diff = temp;
                        result = ans;
                    }
                }
            }
            return result;

        }
    }
}
