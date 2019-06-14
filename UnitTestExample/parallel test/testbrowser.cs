using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace UnitTestExample.parallel_test
{
    [TestFixture]
    [Parallelizable]
    public class testbrowser :browsertest
    {
        [Test]
        [TestCaseSource(typeof(browsertest),"BrowserToRun")]
        public void verifydropdowncount(string browsername)
        {
            setup(browsername);
            driver.Url = "https://www.calculator.net/calorie-calculator.html";
            int dropdowncount = driver.FindElements(By.XPath("//select")).Count;
           Assert.AreEqual(3, dropdowncount);
            Console.WriteLine(dropdowncount);
        }
        [Test]
        [TestCaseSource(typeof(browsertest),"BrowserToRun")]
        public void verifytextboxcount(string browsername)
        {
            setup(browsername);
            driver.Url = "https://www.calculator.net/calorie-calculator.html";
            int textboxcount = driver.FindElements(By.XPath("//input[@type='test']")).Count;
            Assert.AreEqual(textboxcount,31);
            Console.WriteLine(textboxcount);
        }
    }
}
