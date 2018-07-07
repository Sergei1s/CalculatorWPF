using System; // TODO: Решарпер поставил, если поставил, то можешь видеть что этот наймспыс не используется, поэтому он подсвечен серопрозрачным,
              // TODO: используй постоянно Ctrl+Alt+F чтобы отформатировать код
using ClassLibrary;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1 // TODO: Все что ты пишешь чтолжно быть читабельно, любой класс, в том числе тестовый должен описывать что он делает, для чего он есть
                           // TODO: Предлагаю называть по типу When{а тут что же ты тестируешь}
                           // TODO: т.е. для данного случая я бу называл WhenExecutePlusCalculatorOperation. <= т.е. мне даже класс не надо открывать чтобы понять о чем этот тест
    {
        [Test]
        public void Test_Plus() // TODO: тут бы я брал шаблон по типу Should{что же ты ожидаешь от теста}Test 
                                // TODO: например тут ShouldReturnExpetedValueTest
        {
            double x = 5; // TODO: это константа, никогда не изменяется, так явно это и укажи что константа
            double y = 10; // TODO: это константа, никогда не изменяется, так явно это и укажи что константа
            double expected = 15; // TODO: это константа, никогда не изменяется, так явно это и укажи что константа
            Calculator e = new Calculator(); // TODO: Используй var, что за название переменной e? это что за e такое?
            double actual = e.Sum(x, y); // TODO: Используй var, лучше result
            Assert.AreEqual(expected, actual);  // TODO: лучше использовать Assert.That
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


// TODO: На самом деле делать класс для одной операции имеет смысл, но только когда она большая и сложная, тут бы я сделал все тесты в одном файле
// TODO: Но в этом случае имена WhenExecutePlusCalculatorOperation, ShouldReturnExpetedValueTest не верные, поскольку первое название описывает ТОЛЬКО операцию плюс,
// TODO: а во второму названию будет не понятно что она относится к операции плюс если добавятся другие тесты (но при названии класса WhenExecutePlusCalculatorOperation легко понимается какая же именно операция проверяется в ShouldReturnExpetedValueTest)

// TODO: Задание:
// TODO: Добавить тесты, переименовать класс и методы