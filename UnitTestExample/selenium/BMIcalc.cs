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
    public class BMIcalc
    {
        [Test]
        public void category()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            string title = driver.Title;
            Console.WriteLine("Title of the page " + title);
            Console.WriteLine("current url of the page " + driver.Url);
            driver.FindElement(By.LinkText("BMI")).Click();
            Console.WriteLine("Title of the current url of the page " + driver.Title);
            IWebElement age = driver.FindElement(By.XPath("//*[@id='cage']"));
            age.Clear();
            age.SendKeys("22");

            IWebElement heightf = driver.FindElement(By.XPath("//*[@id='cheightfeet']"));
            heightf.Clear();
            heightf.SendKeys("5");
//            Console.WriteLine("print the chnaged value testbox:" + heightf.GetAttribute("value"));
            IWebElement heighti= driver.FindElement(By.XPath("//*[@id='cheightinch']"));
            heighti.Clear();
            heighti.SendKeys("8");
  //          Console.WriteLine("print the chnaged value testbox:" + heighti.GetAttribute("value"));
            IWebElement weight = driver.FindElement(By.XPath("//*[@id='cpound']"));
            weight.Clear();
            weight.SendKeys("60");
    //        Console.WriteLine("print the chnaged value testbox:" + weight.GetAttribute("value"));
            IWebElement cal = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[2]/table/tbody/tr/td/table[4]/tbody/tr/td/input[2]"));
            cal.Click();
        }
    }
}
