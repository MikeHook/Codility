namespace Codility.Tests
{
    using System.Collections;
    using Core;
    using Core.Domain;
    using NUnit.Framework;

    [TestFixture]
    public class BinaryTreeAmplitudeTests
    {

        [Test, TestCaseSource(typeof(MyDataClass), "TestCases")]
        public int Test(Tree a)
        {
            return BinaryTreeAmplitude.Solution(a);
        }

        public class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(null).Returns(0);
                    yield return new TestCaseData(new Tree()).Returns(0);
                    yield return new TestCaseData(new Tree() {X = 1, L = new Tree() {X = 5}, R = new Tree() {X = 9}}).Returns(8);
                    yield return
                        new TestCaseData(new Tree()
                        {
                            X = 1,
                            L = new Tree() {X = 5, L = new Tree() {X = 7}},
                            R = new Tree() {X = 9, L = new Tree() {X = 8}, R = new Tree() {X = 11}}
                        }).Returns(10);
                }
            }
        }

    }
}
