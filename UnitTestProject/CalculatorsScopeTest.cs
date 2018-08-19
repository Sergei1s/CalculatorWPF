using System; 
              // TODO: используй постоянно Ctrl+Alt+F чтобы отформатировать код
using CalculatorScope;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class CalculatorsScopeTest 
                           
    {
        [Test]
        public void ShouldReturnExpetedValueTest() 
        {
            const double x = 5; 
            const double y = 10; 
            const double expected = 15; 
            Calculator e = new Calculator(); 
            var result = e.Sum(x, y); 
            Assert.AreEqual(expected, result); 
        }
        public void ShouldReturnExpetedDifferenceTest()
        {
            const double x = 15;
            const double y = 10;
            const double expected = 5;
            Calculator e = new Calculator();
            var result = e.Minus(x, y);
            Assert.AreEqual(expected, result);
        }
        public void ShouldReturnExpetedMyltipliedTest()
        {
            const double x = 15;
            const double y = 10;
            const double expected = 150;
            Calculator e = new Calculator();
            var result = e.Multiply(x, y);
            Assert.AreEqual(expected, result);
        }
        public void ShouldReturnExpetedQuotientTest()
        {
            const double x = 15;
            const double y = 10;
            const double expected = 1.5f;
            Calculator e = new Calculator();
            var result = e.Division(x, y);
            Assert.AreEqual(expected, result);
        }


    }
}


