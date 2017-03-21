namespace Codility.Tests
{
    using System.Collections;
    using Core;
    using NUnit.Framework;

    [TestFixture]
    public class Lesson1BinaryGapTests
    {

        [Test, TestCaseSource(typeof(MyDataClass), "TestCases")]
        public int Test(int n)
        {
            return Lesson1BinaryGap.Solution(n);
        }

        public class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(9).Returns(2);
                    yield return new TestCaseData(529).Returns(4);
                    yield return new TestCaseData(20).Returns(1);
                    yield return new TestCaseData(15).Returns(0);
                    yield return new TestCaseData(2147483647).Returns(0);
                }
            }
        }

    }
}
