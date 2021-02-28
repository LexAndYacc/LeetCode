using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _18_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            return mySolution(nums, target);
        }

        IList<IList<int>> mySolution(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();


            if (nums == null || nums.Length < 4)
            {
                return result;
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (nums[i] > target && nums[i]>0)
                {
                    break;
                }

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                for (int j = i + 1; j < nums.Length - 2; j++)
                {

                    if (nums[i] + nums[j] > target && nums[i] + nums[j] > 0)
                    {
                        break;
                    }

                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }


                    int left = j + 1, right = nums.Length - 1;

                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];

                        if (sum < target)
                        {
                            while (left < right && nums[left] == nums[++left])
                                ;
                        }
                        else if (sum > target)
                        {
                            while (left < right && nums[right] == nums[--right])
                                ;
                        }
                        else
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });

                            while (left < right && nums[left] == nums[++left])
                                ;
                            while (left < right && nums[right] == nums[--right])
                                ;
                        }
                    }
                }
            }

            return result;
        }
    }
}
