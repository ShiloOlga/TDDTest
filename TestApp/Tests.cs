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
    }
}
