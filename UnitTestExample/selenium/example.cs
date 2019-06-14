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
    public class example
    {
        [Test]
        public void bmicategory()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("BMI")).Click();
            Console.WriteLine("Title of the current url of the page " + driver.Title);
            IWebElement age = driver.FindElement(By.XPath("//*[@id='cage']"));
            age.Clear();
            age.SendKeys("22");
            Console.WriteLine("print the chnaged value testbox:" + age.GetAttribute("value"));
            IList<IWebElement> gender = driver.FindElements(By.XPath("//*[@id='calinputtable']"));
            IWebElement heightf = driver.FindElement(By.XPath("//*[@id='cheightfeet']"));
            heightf.Clear();
            heightf.SendKeys("5");
            Console.WriteLine("print the chnaged value testbox:" + heightf.GetAttribute("value"));
            IWebElement heighti = driver.FindElement(By.XPath("//*[@id='cheightinch']"));
            heighti.Clear();
            heighti.SendKeys("8");
            Console.WriteLine("print the chnaged value testbox:" + heighti.GetAttribute("value"));
            IWebElement weight = driver.FindElement(By.XPath("//*[@id='cpound']"));
            weight.Clear();
            weight.SendKeys("60");
            Console.WriteLine("print the chnaged value testbox:" + weight.GetAttribute("value"));
            IWebElement cal = driver.FindElement(By.XPath("//*[@id='content']/div[4]/div[2]/table/tbody/tr/td/table[4]/tbody/tr/td/input[2]"));
            cal.Click();

            IWebElement bmivalue = driver.FindElement(By.XPath("//*[@id='content']/div[4]/div/b"));
            Console.WriteLine(bmivalue.Text);
            string start = bmivalue.Text;
            int postindx = start.IndexOf("=");
            string modify = start.Substring(postindx + 1);
            Console.WriteLine(postindx+" "+modify);
            string strbmi1 = modify.Replace("kg/m2", " ");
            Console.WriteLine(strbmi1.Trim());
            double bmidouble = double.Parse(strbmi1.Trim());
            Console.WriteLine(bmidouble);
            string cat = bmifun(bmidouble);
            Console.WriteLine(cat);
            IWebElement newcat = driver.FindElement(By.XPath("//*[@id='content']/div[4]/div/font/b"));
            string newcatstr = newcat.Text;
            if (newcatstr == cat)
                Console.WriteLine("test pass");
            else
                Console.WriteLine("test not pass");
        }
        public string bmifun(double a)
        {
            string expcat;
            if (a < 16)
                expcat = "severe thinness";
            else if (a >= 16 && a <= 17)
                expcat = "Modrate thiness";
            else if (a >= 17 && a <= 18)
                expcat = "Mid thiness";
            else if (a >= 18 && a <= 25)
                expcat = "normal";
            else if (a >= 25 && a <= 30) 
                expcat = "overweight";
            else if (a >= 30 && a <= 45)
                expcat = "over weight class 1";
            else
                expcat = "over weight class 2";
            return expcat;
        }
    }
}
