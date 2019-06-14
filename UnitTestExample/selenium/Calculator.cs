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
    public class Calculator
    {
        [Test]
        public void locateeles()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            drv.Manage().Window.Maximize();
            IWebElement ageele = drv.FindElement(By.Id("cage"));
            Console.WriteLine("print the current value testbox:" + ageele.GetAttribute("value"));
            ageele.Clear();
            ageele.SendKeys("45");
            Console.WriteLine("print the current value tesxt box:" + ageele.GetAttribute("value"));
            Console.WriteLine(ageele.GetAttribute("id") + " " + ageele.GetAttribute("name"));
            Console.WriteLine(ageele.TagName);

            IList<IWebElement> gender = drv.FindElements(By.Name("csex"));
            foreach(IWebElement gen in gender)
            {
                if (gen.GetAttribute("value").Equals("f"))
                {
                    if(!gen.Selected)
                    {
                        gen.Click();
                        break;
                    }
                }
            }
            IWebElement table = drv.FindElement(By.ClassName("cinfoT"));
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));
            foreach(IWebElement row in rows)
            {
                IList<IWebElement> cols = row.FindElements(By.TagName("td"));
                {
                    foreach(IWebElement col in cols)
                    {
                        Console.Write(col.Text + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
