using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    public class _90_SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            return bestSolution(nums);
        }

        IList<IList<int>> bestSolution(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new List<int>());
            List<int> l = new List<int>();

            int lastpos = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                int count = list.Count;
                int start = 0;
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    start = lastpos;
                }
                for (int j = start; j < count; j++)
                {
                    List<int> ll = new List<int>();
                    for (int r = 0; r < list.ElementAt(j).Count; r++)
                    {
                        ll.Add(list.ElementAt(j).ElementAt(r));
                    }
                    ll.Add(nums[i]);
                    list.Add(ll);
                }
                lastpos = count;
            }
            return list;
        }

    }
}
