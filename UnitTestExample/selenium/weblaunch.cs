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
    class weblaunch
    {
        [Test]
        public void launchchromebrowser()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("http://www.google.com");
        }
    }
}
