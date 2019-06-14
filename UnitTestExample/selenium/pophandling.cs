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
    public class pophandling
    {
        [Test]
        public void alertpop()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("alert('This is an information box')");
            System.Threading.Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            string alertmsg = alert.Text;
            alert.Accept();
            if (alertmsg.Equals("This is an information box"))
                Console.WriteLine("Alert Message match found");
            else
                Console.WriteLine("Alert message match not found");

            //conform alert popup
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("confirm('Do u want to continue(y/n)?')");
            System.Threading.Thread.Sleep(2000);
            alert = driver.SwitchTo().Alert();
            alertmsg = alert.Text;
            alert.Dismiss();
            if (alertmsg.Equals("Do u want to continue(y/n)?"))
                Console.WriteLine("Alert Message match found");
            else
                Console.WriteLine("Alert Message match not found");
        }
    }
}
