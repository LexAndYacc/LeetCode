using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._341_FlattenNestedListIterator;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _341_FlattenNestedListIteratorTest
    {
        class NestedIntegers : NestedInteger
        {
            int value;
            IList<NestedInteger> list = null;

            public NestedIntegers(int value)
            {
                this.value = value;
            }

            public NestedIntegers(IList<NestedInteger> list)
            {
                this.list = list;
            }

            public int GetInteger()
            {
                return value;
            }

            public IList<NestedInteger> GetList()
            {
                return list;
            }

            public bool IsInteger()
            {
                return list == null;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            IList<NestedInteger> list = new List<NestedInteger>();
            list.Add(new NestedIntegers(new List<NestedInteger>() {
                new NestedIntegers(1),
                new NestedIntegers(1)
            }));
            list.Add(new NestedIntegers(2));
            list.Add(new NestedIntegers(new List<NestedInteger>() {
                new NestedIntegers(1),
                new NestedIntegers(1)
            }));

            NestedIterator nestedIterator = new NestedIterator(list);

            int[] expected = { 1, 1, 2, 1, 1 };

            for (int i = 0; nestedIterator.HasNext() || i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], nestedIterator.Next());
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            IList<NestedInteger> list = new List<NestedInteger>();
            list.Add(new NestedIntegers(1));
            list.Add(new NestedIntegers(new List<NestedInteger>() {
                new NestedIntegers(4),
                new NestedIntegers(new List<NestedInteger>() {
                    new NestedIntegers(6)
                })
            }));

            NestedIterator nestedIterator = new NestedIterator(list);

            int[] expected = { 1, 4, 6 };

            for (int i = 0; nestedIterator.HasNext() || i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], nestedIterator.Next());
            }
        }

    }
}
