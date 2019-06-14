using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestExample.selenium
{
    [TestFixture]
    public class stylepage
    {
        [Test]
        public void csstest()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            drv.Manage().Window.Maximize();
            IList<IWebElement> css = drv.FindElements(By.CssSelector(".cinfoT"));
            //string n = css.Text;
        }
    }
}
