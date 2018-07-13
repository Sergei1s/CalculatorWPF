using System; // TODO: Решарпер поставил, если поставил, то можешь видеть что этот наймспыс не используется, поэтому он подсвечен серопрозрачным,
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
            const double x = 5; // TODO: это константа, никогда не изменяется, так явно это и укажи что константа
            const double y = 10; // TODO: это константа, никогда не изменяется, так явно это и укажи что константа
            const double expected = 15; // TODO: это константа, никогда не изменяется, так явно это и укажи что константа
            Calculator e = new Calculator(); // TODO: Используй var, что за название переменной e? это что за e такое?
            var result = e.Sum(x, y); // TODO: Используй var, лучше result
            Assert.AreEqual(expected, result);  // TODO: лучше использовать Assert.That
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


// TODO: На самом деле делать класс для одной операции имеет смысл, но только когда она большая и сложная, тут бы я сделал все тесты в одном файле
// TODO: Но в этом случае имена WhenExecutePlusCalculatorOperation, ShouldReturnExpetedValueTest не верные, поскольку первое название описывает ТОЛЬКО операцию плюс,
// TODO: а во второму названию будет не понятно что она относится к операции плюс если добавятся другие тесты (но при названии класса WhenExecutePlusCalculatorOperation легко понимается какая же именно операция проверяется в ShouldReturnExpetedValueTest)

// TODO: Задание:
// TODO: Добавить тесты, переименовать класс и методы