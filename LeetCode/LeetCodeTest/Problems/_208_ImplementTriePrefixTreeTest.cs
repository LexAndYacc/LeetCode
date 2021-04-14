using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._208_ImplementTriePrefixTree;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _208_ImplementTriePrefixTreeTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            Assert.AreEqual(true, trie.Search("apple"));   // 返回 True
            Assert.AreEqual(false, trie.Search("app"));     // 返回 False
            Assert.AreEqual(true, trie.StartsWith("app")); // 返回 True
            trie.Insert("app");
            Assert.AreEqual(true, trie.Search("app"));     // 返回 True
        }
    }
}
