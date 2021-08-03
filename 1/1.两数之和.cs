/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        return Solution2(nums, target);
    }
    //暴力解法
    public int[] Solution1(int[] nums, int target)
    {

        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }

    public int[] Solution2(int[] nums, int target)
    {
        int[] result = new int[2];
        System.Collections.Generic.Dictionary<int,int> dic = new System.Collections.Generic.Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            if(dic.ContainsKey(target - nums[i])){
                result[0] = dic[target - nums[i]];
                result[1] = i;
                break;
            }
            else{
                dic[nums[i]] = i;
            }
        }


        return result;
    }
}
// @lc code=end

