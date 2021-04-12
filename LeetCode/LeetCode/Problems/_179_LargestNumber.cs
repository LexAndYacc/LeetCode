using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _179_LargestNumber
    {
        public string LargestNumber(int[] nums)
        {
            return mySolution(nums);
        }

        string mySolution(int[] nums)
        {
            string result = string.Empty;
            Array.Sort(nums, (x, y) =>
            {
                string xStr = x.ToString();
                string yStr = y.ToString();

                return -(xStr + yStr).CompareTo(yStr + xStr);
            });

            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i].ToString();
            }

            result = result.TrimStart('0');
            if (result.Length == 0)
            {
                result = "0";
            }

            return result;
        }
    }
}
