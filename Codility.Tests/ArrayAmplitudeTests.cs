namespace Codility.Tests
{
    using System.Collections;
    using Core;
    using NUnit.Framework;

    [TestFixture]
    public class ArrayAmplitudeTests
    {

        [Test, TestCaseSource(typeof(MyDataClass), "TestCases")]
        public int Test(int[] a)
        {
            return ArrayAmplitude.Solution(a);
        }

        public class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new int[] { 9,0}).Returns(9);
                    yield return new TestCaseData(new int[] { 2147483647, 0}).Returns(2147483647);
                    yield return new TestCaseData(new int[] { 2147483647, -1}).Returns(0);  //Unknown what this answer should be
                    yield return new TestCaseData(new int[] { 1}).Returns(1);
                    yield return new TestCaseData(new int[] { 1, 1}).Returns(0);
                    yield return new TestCaseData(new int[] { }).Returns(0);
                }
            }
        }

    }
}
