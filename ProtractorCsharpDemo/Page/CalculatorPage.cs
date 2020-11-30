using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;
using ProtractorCsharpDemo.Base;

namespace ProtractorCsharpDemo.Page
{
    public class CalculatorPage : BasePage
    {
        private readonly By _firstNumberTextBox = NgBy.Model("first");
        private readonly By _secondNumberTextBox = NgBy.Model("second");
        private readonly By _operatorDropdown = NgBy.Model("operator");
        private readonly By _goButton = By.Id("gobutton");
        private readonly By _resultLabel = By.TagName("h2");

        public CalculatorPage(IWebDriver driver, NgWebDriver ngDriver) : base(driver,ngDriver)
        {
        }

        public void CalculateNumbers(string firstNumber, string secondNumber, MathematicalOperation mathematicalOperation)
        {
            SetFirstNumber(firstNumber);
            SetSecondNumber(secondNumber);
            SelectOperation(mathematicalOperation);
            ClickGoButton();
        }

        public string GetResult()
        {
            return Driver.FindElement(_resultLabel).Text;
        }

        private void SetFirstNumber(string firstNumber)
        {
            NgDriver.FindElement(_firstNumberTextBox).SendKeys(firstNumber);
        }

        private void SetSecondNumber(string secondNumber)
        {
            NgDriver.FindElement(_secondNumberTextBox).SendKeys(secondNumber);
        }

        private void SelectOperation(MathematicalOperation mathematicalOperation)
        {
            var dropdown = new SelectElement(Driver.FindElement(_operatorDropdown));
            dropdown.SelectByValue(mathematicalOperation.ToString());
        }

        private void ClickGoButton()
        {
            Driver.FindElement(_goButton).Click();
        }
    }
}