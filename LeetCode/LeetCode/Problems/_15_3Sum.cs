using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            return mySolution(nums);
        }

        IList<IList<int>> mySolution(int[] nums)
        {
            var result = new List<IList<int>>();

            if (nums == null || nums.Length < 3)
            {
                return result;
            }

            Array.Sort(nums);

            for (int k = 0; k < nums.Length - 2; k++)
            {
                if (nums[k] > 0)
                {
                    break;
                }

                if (k > 0 && nums[k] == nums[k - 1])
                {
                    continue;
                }

                int left = k + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[k] + nums[left] + nums[right];

                    if (sum < 0)
                    {
                        while (left < right && nums[left] == nums[++left])
                            ;
                    }
                    else if (sum > 0)
                    {
                        while (left < right && nums[right] == nums[--right])
                            ;
                    }
                    else
                    {
                        result.Add(new List<int>() { nums[k], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[++left])
                            ;
                        while (left < right && nums[right] == nums[--right])
                            ;
                    }
                }
            }

            return result;
        }




    }
}
