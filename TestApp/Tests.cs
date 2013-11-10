﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace TestApp
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void TestAddEmptyString()
        {
            var sut = new Calc();
            var sum = sut.Add();
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void TestAddOne()
        {
            var sut = new Calc();
            var sum = sut.Add("1");
            Assert.AreEqual(1, sum);
        }
    }
}
