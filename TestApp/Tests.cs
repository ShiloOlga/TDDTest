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
        [TestCase("1,3", 4)]
        [TestCase("10,32", 42)]
        [TestCase("8,4,2", 14)]
        [TestCase("8,4\n2", 14)]
        [TestCase("//;\n10;3", 13)]
        [TestCase("//;\n1;3,2\n4", 10)]
        public void TestAdd(string input, decimal result)
        {
            var sum = sut.Add(input);
            Assert.AreEqual(result, sum);
        }

        [TestCase("-2", "negatives not allowed: -2")]
        [TestCase("-3,-1", "negatives not allowed: -3,-1")]
        [TestCase("//;\n1;-3,-2\n-4", "negatives not allowed: -3,-2,-4")]
        public void TestAddWithExceptionOnNegative(string input, string message)
        {
            var e = Assert.Throws(typeof(Exception), () => sut.Add(input));
            Assert.That(e.Message.Equals(message));
        }


        [TestCase("3000", 0)]
        [TestCase("0,1000", 0)]
        [TestCase("2999,57", 57)]
        [TestCase("1110,9862", 0)]
        [TestCase("//;\n10;8073", 10)]
        public void TestAddThousands(string input, decimal result)
        {
            var sum = sut.Add(input);
            Assert.AreEqual(result, sum);
        }
    }
}
