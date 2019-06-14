using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
namespace UnitTestExample.selenium
{
    [TestFixture]
    public class Queryui
    {
        [Test]
        public void frametest()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            drv.Manage().Window.Maximize();
            IWebElement frameele = drv.FindElement(By.XPath("//*[@id='content']/iframe"));
            drv.SwitchTo().Frame(frameele);
            System.Threading.Thread.Sleep(2000);
            IWebElement dragele = drv.FindElement(By.XPath("//*[@id='draggable']"));
            IWebElement dropele = drv.FindElement(By.XPath("//*[@id='droppable']"));
            Actions actions = new Actions(drv);
            actions.DragAndDrop(dragele, dropele).Perform();
            if (dropele.Text.Equals("Dropped"))
                Console.WriteLine("drag and drop are pass");
            else
                Console.WriteLine("drag and drop are failed");
        }
    }
}
