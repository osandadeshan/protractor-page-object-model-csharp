using OpenQA.Selenium;
using Protractor;

namespace ProtractorCsharpDemo.Page
{
    public class BasePage
    {
        protected readonly IWebDriver Driver;
        protected static NgWebDriver NgDriver;

        protected BasePage(IWebDriver driver, NgWebDriver ngDriver)
        {
            Driver = driver;
            NgDriver = ngDriver;
        }
    }
}