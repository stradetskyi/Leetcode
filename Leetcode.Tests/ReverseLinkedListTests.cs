using Leetcode.Issues;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Leetcode.Tests
{
    [TestFixture]
    public class ReverseLinkedListTests
    {
        private ReverseLinkedList _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ReverseLinkedList();
        }

        [Test]
        [TestCase(new [] { 1, 2, 3, 4, 5 }, new [] { 5, 4, 3, 2, 1 })]
        [TestCase(new [] { 1, 2 }, new [] { 2, 1 })]
        [TestCase(new int[0], new int[0])]
        public void RunSolution_ReverseList_NoError(int[] head, int[] result)
        {
            var headNode = head.CovertToListNode();
            var resNode = _solution.ReverseList(headNode);

            var resArray = resNode.CovertToArray();
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], resArray[i]);
            }
        }
    }

    public static class Extension
    {
        public static ListNode CovertToListNode(this int[] head)
        {
            if (head == null || 
                head.Length == 0) 
                return null;

            if (head.Length == 1)
                return new ListNode(head[0]);

            return new ListNode(head[0], head.SubArray(1, head.Length-1).CovertToListNode());
        }

        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        public static int[] CovertToArray(this ListNode head)
        {
            if (head == null)
                return Array.Empty<int>();

            var list = new List<int> { head.val };
            list.AddRange(head.next?.CovertToArray() ?? Array.Empty<int>());

            return list.ToArray();
        }
    }
}
