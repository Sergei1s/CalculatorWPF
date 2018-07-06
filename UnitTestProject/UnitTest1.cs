using System;
using ClassLibrary;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test_Plus_Expected()
        {
            double x = 5;
            double y = 10;
            double expected = 15;
            Calculator e = new Calculator();
            double actual = e.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
        public void Test_Minus_Expected()
        {
            double x = 15;
            double y = 10;
            double expected = 5;
            Calculator e = new Calculator();
            double actual = e.Minus(x, y);
            Assert.AreEqual(expected, actual);
        }
        public void Test_Multiply_Expected()
        {
            double x = 15;
            double y = 10;
            double expected = 150;
            Calculator e = new Calculator();
            double actual = e.Multiply(x, y);
            Assert.AreEqual(expected, actual);
        }
        public void Test_Divide_Expected()
        {
            double x = 15;
            double y = 10;
            double expected = 1.5f;
            Calculator e = new Calculator();
            double actual = e.Division(x, y);
            Assert.AreEqual(expected, actual);
        }


    }
}
