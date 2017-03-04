using NUnit.Framework;

namespace NUnitHelloWorld
{
    [TestFixture]
    public class TestFixture
    {
        [Test]
        public void ThisTestShouldPass()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void ThisTestShouldFail()
        {
            Assert.IsTrue(false);
        }
    }
}
