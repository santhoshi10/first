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
    public class startswith
    {
        [Test]
        public void withc()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            drv.Manage().Window.Maximize();
            //IWebElement agelabel1 = drv.FindElement(By.XPath("//*[@id='calinputtable']/tbody/tr[1]/td[1]"));
            IList<IWebElement> starts_withc_idxpath = drv.FindElements(By.XPath("//*[starts-with(@id,'c')]"));
            Console.WriteLine("printing all eles starts with c");
            foreach(IWebElement ele in starts_withc_idxpath)
            {
                Console.WriteLine(ele.GetAttribute("id"));
            }
        }
    }
}
