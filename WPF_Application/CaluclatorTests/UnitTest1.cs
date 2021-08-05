using NUnit.Framework;
using Calculator_Model;

namespace CaluclatorTests
{
    public class IntegerCalc_Tests
    {
        public class SimpleCalculatorTests
        {
            Calculator _calculator;
            [SetUp]
            public void Setup()
            {
                _calculator = new Calculator();
            }
            [Test]
            public void WhenSetUpWithTwoDoubles_Add_ReturnCorrectAnswer()
            {
                _calculator.Num1 = 2.5;
                _calculator.Num2 = 7.5;

                Assert.That(_calculator.Add(), Is.EqualTo(10.0));
            }
        }
        

        
    }
}