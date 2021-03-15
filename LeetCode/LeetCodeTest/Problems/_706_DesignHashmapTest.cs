using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._706_DesignHashmap;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _706_DesignHashmapTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.Put(1, 1); // myHashMap 现在为 [[1,1]]
            myHashMap.Put(2, 2); // myHashMap 现在为 [[1,1], [2,2]]
            Assert.AreEqual(1, myHashMap.Get(1));    // 返回 1 ，myHashMap 现在为 [[1,1], [2,2]]
            Assert.AreEqual(-1, myHashMap.Get(3));    // 返回 -1（未找到），myHashMap 现在为 [[1,1], [2,2]]
            myHashMap.Put(2, 1); // myHashMap 现在为 [[1,1], [2,1]]（更新已有的值）
            myHashMap.Get(2);    // 返回 1 ，myHashMap 现在为 [[1,1], [2,1]]
            myHashMap.Remove(2); // 删除键为 2 的数据，myHashMap 现在为 [[1,1]]
            myHashMap.Get(2);    // 返回 -1（未找到），myHashMap 现在为 [[1,1]]

        }

    }
}
