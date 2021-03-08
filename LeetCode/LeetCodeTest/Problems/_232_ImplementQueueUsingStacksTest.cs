using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._232_ImplementQueueUsingStacks;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _232_ImplementQueueUsingStacksTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Push(1); // queue is: [1]
            myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
            Assert.AreEqual(1, myQueue.Peek()); // return 1
            Assert.AreEqual(1, myQueue.Pop()); // return 1, queue is [2]
            Assert.AreEqual(false, myQueue.Empty()); // return false
        }


    }
}
