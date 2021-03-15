using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _706_DesignHashmap
    {
        public class MyHashMap
        {
            Dictionary<int, int> dic;
            /** Initialize your data structure here. */
            public MyHashMap()
            {
                dic = new Dictionary<int, int>();
            }

            /** value will always be non-negative. */
            public void Put(int key, int value)
            {
                dic[key] = value;
            }

            /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
            public int Get(int key)
            {
                if(dic.ContainsKey(key))
                {
                    return dic[key];
                }
                return -1;
            }

            /** Removes the mapping of the specified value key if this map contains a mapping for the key */
            public void Remove(int key)
            {
                dic.Remove(key);
            }
        }
    }
}
