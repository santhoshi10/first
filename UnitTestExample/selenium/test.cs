using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
namespace UnitTestExample.selenium
{
    [TestFixture]
    public class test
    {
        [Test]
        public void test1()
        {
            var connectionstringval = ConfigurationManager.ConnectionStrings["DbConnectionString"];
            Console.WriteLine("connection string: "+ connectionstringval);
            var appurl = ConfigurationManager.AppSettings["URL"];
            Console.WriteLine("Application URL " + appurl);
        }
    }
}
