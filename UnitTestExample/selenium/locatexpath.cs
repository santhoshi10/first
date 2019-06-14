using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace UnitTestExample.selenium
{
    [TestFixture]
    public class locatexpath
    {
        [Test]
        public void xpath()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            drv.Manage().Window.Maximize();
            IWebElement agelabel =drv.FindElement(By.XPath("//*[@id='calinputtable']/tbody/tr[1]/td[1]"));
            string n = agelabel.Text;
            Console.WriteLine("print the current value " + n);
        }
    }
}
