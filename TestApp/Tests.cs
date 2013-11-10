using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace TestApp
{
    [TestFixture]
    class Tests
    {
        private Calc sut = new Calc();

        [Test]
        public void TestAddEmptyString()
        {
            var sum = sut.Add();
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void TestAddOne()
        {
            var sum = sut.Add("1");
            Assert.AreEqual(1, sum);
        }

        [Test]
        public void TestAddTwo()
        {
            var sum = sut.Add("2");
            Assert.AreEqual(2, sum);
        }

        [Test]
        public void TestAddZeroZero()
        {
            var sum = sut.Add("0,0");
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void TestAddZeroOne()
        {
            var sum = sut.Add("0,1");
            Assert.AreEqual(1, sum);
        }

        [Test]
        public void TestAddOneZero()
        {
            var sum = sut.Add("1,0");
            Assert.AreEqual(1, sum);
        }

        [TestCase("", 0)]
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("0,1", 1)]
        [TestCase("1,0", 1)]
        [TestCase("0,2", 2)]
        [TestCase("2,0", 2)]
        [TestCase("1,2", 3)]
        [TestCase("2,1", 3)]
        [TestCase("2,2", 4)]
        public void TestAdd(string input, decimal result)
        {
            var sum = sut.Add(input);
            Assert.AreEqual(result, sum);
        }
    }
}
