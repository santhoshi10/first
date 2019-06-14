using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace UnitTestExample.parallel_test
{
    public class browsertest
    {
        protected IWebDriver driver;
        public static IEnumerable<string> BrowserToRun()
        {
            string[] browsers = { "chrome", "ie" };
            foreach(string b in browsers)
            {
                yield return b;
            }
        }
        public void setup(string browsername)
        {
            if (browsername.Equals("chrome"))
                driver = new ChromeDriver();
            else if (browsername.Equals("ie"))
                driver = new InternetExplorerDriver();
            else if (browsername.Equals("firefox"))
                driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
        }
        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
