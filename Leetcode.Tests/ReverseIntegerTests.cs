using Leetcode.Issues;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ReverseIntegerTests
    {
        private ReverseInteger _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ReverseInteger();
        }

        [Test]
        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(1534236469, 0)]
        public void RunSolution_CheckPositiveCases_NoError(int x, int newX)
        {
            Assert.AreEqual(newX, _solution.Reverse(x));
        }
    }
}
