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
    public class webdriver
    {
        [Test]
        public void iwait()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement menu = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/a"));
            menu.Click();
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));
                IWebElement ele = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a"));
                Console.WriteLine(ele.Text);
            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine("Printer ele not found");
            }
        }
    }
}
