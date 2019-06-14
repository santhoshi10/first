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
    public class Citibank
    {
        [Test]
        public void windowhandel()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.online.citibank.co.in/");
            drv.Manage().Window.Maximize();
            string parentwindow = drv.CurrentWindowHandle;
            Console.WriteLine("parent window id= "+parentwindow);
            IWebElement login = drv.FindElement(By.XPath("//*[@id='nav']/ul[3]/li/a/span[2]"));
            login.Click();
            IList<string> windids = drv.WindowHandles;
            Console.WriteLine("main window "+windids.Count);
            string main = null;
            string sub = null;
            for(int i=0;i<windids.Count;i++)
            {
                main = windids[0];
                sub = windids[1];
            }
            Console.WriteLine("mainwindow= " + main);
            Console.WriteLine("subwindow= " + sub);
            drv.SwitchTo().Window(sub);
            System.Threading.Thread.Sleep(2000);
            drv.FindElement(By.XPath("//*[@id='User_Id']")).SendKeys("Santhoshi");
            //System.Threading.Thread.Sleep(2000);
            drv.Close();
            drv.SwitchTo().Window(main);
            drv.FindElement(By.XPath("//*[@id='topMnuinsurance']")).Click();

        }
    }
}
