namespace Codility.Tests
{
    using Core;
    using NUnit.Framework;

    [TestFixture]
    public class BallardTests
    {

        [Test]
        public void test1()
        {
            var result = BallardSolution.Solution(new int[] {});

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
