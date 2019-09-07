using NUnit.Framework;
using TenMinWalk;

namespace TenMinWalkTests
{
    public class TenMinWalkTests
    {
        private Walk walk;

        [SetUp]
        public void Setup()
        {
            walk = new Walk();
        }

        [TestCase(new[] { 'w', 's', 'e', 'e', 'n', 'n', 'e', 's', 'w', 'w' }, "true")]
        [TestCase(new[] { 's', 'e', 'e', 'n', 'n', 'e', 's', 'w', 'w' }, "false")]
        [TestCase(new[] { 'w', 's', 'e', 'n', 'n', 'e', 's', 'w', 'w', 'w' }, "false")]
        [TestCase(new[] { 'w', 's' }, "false")]


        public void TenMinuteWalkMustReturnToDestination(char[] route, string expected)
        {
            string actual = walk.Walking(route);
            Assert.AreEqual(expected, actual);
        }
    }
}


