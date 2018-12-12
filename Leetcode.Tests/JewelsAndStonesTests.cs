using Leetcode.Issues;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class JewelsAndStonesTests
    {
	    private JewelsAndStones _solution;

		[SetUp]
	    public void Setup()
	    {
		    _solution = new JewelsAndStones();
        }

        [Test]
		[TestCase("aA", "aAAbbbb", 3)]
		[TestCase("z", "ZZ", 0)]
        public void RunSolution_CheckPositiveCases_NoError(string j, string s, int count)
        {
	        Assert.AreEqual(count, _solution.NumJewelsInStones(j, s));
        }
    }
}
