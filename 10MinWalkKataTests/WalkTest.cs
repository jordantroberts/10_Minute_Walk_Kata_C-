using NUnit.Framework;
using TenMinWalk;

namespace TenMinWalkTests
{
    public class TenMinWalkTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WalkMustOnlyLast10Minutes()
        {
            Walk walk = new Walk();
            string actual = walk.Walking(new[] { 'w', 's', 'e', 'e', 'n', 'n', 'e', 's', 'w', 'w' });
            string expected = "true";
            Assert.AreEqual(actual, expected);

        }
    }
}

