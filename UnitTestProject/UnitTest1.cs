using System;
using ClassLibrary;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test_Plus()
        {
            double x = 5;
            double y = 10;
            double expected = 15;
            Calculator e = new Calculator();
            double actual = e.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
