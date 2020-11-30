using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using ProtractorCsharpDemo.Base;

namespace ProtractorCsharpDemo.Test
{
    [TestFixture]
    public class BaseTest
    {
        private readonly string _baseUrl = Constants.BaseUrl;
        protected IWebDriver Driver;
        protected NgWebDriver NgDriver;
        
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            NgDriver = new NgWebDriver(Driver);
            NgDriver.Manage().Window.Maximize();
            NgDriver.Url = _baseUrl;
        }
        
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}