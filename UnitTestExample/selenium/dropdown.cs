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
    public class dropdown
    {
        [Test]
        public void autodown()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            drv.Manage().Window.Maximize();
            IWebElement actdd=drv.FindElement(By.Id("cactivity"));
            SelectElement sle = new SelectElement(actdd);
            Console.WriteLine("default dropdown value "+ sle.SelectedOption.Text);
            sle.SelectByIndex(0);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("currentvalue canged to index " + sle.SelectedOption.Text);
            sle.SelectByValue("1.55");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("current value changed to active dropdown "+ sle.SelectedOption.Text);
            sle.SelectByValue("1.9");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("current value changed to active dropdown " + sle.SelectedOption.Text);
            Console.WriteLine("now is it multiple dropdown " + sle.IsMultiple);

        }
    }
}
