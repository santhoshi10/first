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
    public class openlinks
    {
        [Test]
        public void links()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            drv.Manage().Window.Maximize();
            string title = drv.Title;
            Console.WriteLine("Title of the page " +title);
            Console.WriteLine("current url of the page " +drv.Url);
            drv.FindElement(By.LinkText("BMI")).Click();
            Console.WriteLine("Title of the current url of the page " + drv.Title);
            drv.Navigate().Back();
            System.Threading.Thread.Sleep(1000);
            drv.Navigate().Forward();
            drv.FindElement(By.PartialLinkText("Watcher")).Click();
            System.Threading.Thread.Sleep(1000);
            drv.Navigate().Refresh();
        }
    }
}
