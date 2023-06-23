using Leetcode.Issues;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class UniqueEmailAddressesTests
    {
        private UniqueEmailAddresses _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new UniqueEmailAddresses();
        }

        [Test]
        [TestCase(new[]
        {
            "test.email+alex@leetcode.com",
            "test.e.mail+bob.cathy@leetcode.com",
            "testemail+david@lee.tcode.com"
        }, 2)]
        public void RunSolution_CheckPositiveCases_NoError(string[] emails, int count)
        {
            Assert.AreEqual(count, _solution.NumUniqueEmails(emails));
        }
    }
}
