using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace UnitTestExample.selenium
{
    [TestFixture]
    public class waitaction
    {
        [Test]
        public void action()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://demo.opencart.com/");
            drv.Manage().Window.Maximize();
            drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement componentmenu = drv.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/a"));
            componentmenu.Click();
            try
            {
                WebDriverWait wait = new WebDriverWait(drv, TimeSpan.FromSeconds(60));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/a")));
                IWebElement printerele = drv.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a"));
                Console.WriteLine(printerele);
                Actions act = new Actions(drv);
                act.MoveToElement(printerele).Click().Build().Perform();
                Console.WriteLine(printerele.Text);
            }
            catch(NoSuchElementException)
            {
                Console.WriteLine("element not found");
            }
        }

    }
}
