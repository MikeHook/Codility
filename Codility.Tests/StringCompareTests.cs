using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tests
{
    using BallardChalmers.Test;
    using NUnit.Framework;

    [TestFixture]
    public class StringCompareTests
    {
        [Test]
        public void test1()
        {
            var result = StringCompare.Solution("abc", "xyz");

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void test2()
        {
            var result = StringCompare.Solution("abc", "abc");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void test3()
        {
            var result = StringCompare.Solution("xyz", "abc");

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void test4()
        {
            var result = StringCompare.Solution("aab", "aac");

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void test5()
        {
            var result = StringCompare.Solution("aac", "aab");

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
