using NUnit.Framework;
using ProtractorCsharpDemo.Base;
using ProtractorCsharpDemo.Page;

namespace ProtractorCsharpDemo.Test
{
    [TestFixture]
    public class CalculatorTest : BaseTest
    {
        private CalculatorPage _calculatorPage;
        
        [SetUp]
        public void Before()
        {
            _calculatorPage = new CalculatorPage(Driver, NgDriver);
        }
        
        [Test(Description = "Verify that the two numbers can be added")]
        public void TestAddition()
        {
            const string firstNumber = "2525";
            const string secondNumber = "5252";
            const string expectedResult = "7777";
            
            _calculatorPage.CalculateNumbers(firstNumber, secondNumber, MathematicalOperation.ADDITION);
            NgDriver.WaitForAngular();
            
            Assert.AreEqual(expectedResult, _calculatorPage.GetResult());
        }
        
        [Test(Description = "Verify that the two numbers can be subtracted")]
        public void TestSubtraction()
        {
            const string firstNumber = "5252";
            const string secondNumber = "2525";
            const string expectedResult = "2727";
            
            _calculatorPage.CalculateNumbers(firstNumber, secondNumber, MathematicalOperation.SUBTRACTION);
            NgDriver.WaitForAngular();
            
            Assert.AreEqual(expectedResult, _calculatorPage.GetResult());
        }
        
        [Test(Description = "Verify that the two numbers can be divided")]
        public void TestDivision()
        {
            const string firstNumber = "5252";
            const string secondNumber = "2525";
            const string expectedResult = "2.08";
            
            _calculatorPage.CalculateNumbers(firstNumber, secondNumber, MathematicalOperation.DIVISION);
            NgDriver.WaitForAngular();
            
            Assert.AreEqual(expectedResult, _calculatorPage.GetResult());
        }
        
        [Test(Description = "Verify that the two numbers can be multiplied")]
        public void TestMultiplication()
        {
            const string firstNumber = "5252";
            const string secondNumber = "2525";
            const string expectedResult = "13261300";
            
            _calculatorPage.CalculateNumbers(firstNumber, secondNumber, MathematicalOperation.MULTIPLICATION);
            NgDriver.WaitForAngular();
            
            Assert.AreEqual(expectedResult, _calculatorPage.GetResult());
        }
        
        [Test(Description = "Verify that the two numbers can be modulo")]
        public void TestModulo()
        {
            const string firstNumber = "5252";
            const string secondNumber = "2525";
            const string expectedResult = "202";
            
            _calculatorPage.CalculateNumbers(firstNumber, secondNumber, MathematicalOperation.MODULO);
            NgDriver.WaitForAngular();
            
            Assert.AreEqual(expectedResult, _calculatorPage.GetResult());
        }
    }
}