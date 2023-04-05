using Leetcode.Issues.CustomIssues;
using NUnit.Framework;

namespace Leetcode.Tests.CustomIssues
{
    public class MaximumProfitTests
    {
        private MaximumProfit _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new MaximumProfit();
        }

        [Test]
        [TestCase(new[] { 45, 56, 5, 7, 3, 57, 23, 24, 12, 2, 40 }, 54)]
        [TestCase(new[] { 4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1 }, 28)]
        public void RunSolution_CheckPositiveCases_NoError(int[] input, int expectedProfit)
        {
            Assert.AreEqual(expectedProfit, _solution.MaximumProfitSearch_LinearSolution(input));
        }

        [Test]
        [TestCase(new[] { 45, 56, 5, 7, 3, 57, 23, 24, 12, 2, 40 }, 54)]
        [TestCase(new[] { 4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1 }, 28)]
        public void RunSolution_Improved_CheckPositiveCases_NoError(int[] input, int expectedProfit)
        {
            Assert.AreEqual(expectedProfit, _solution.MaximumProfitSearch_Improved(input));
        }
    }
}
