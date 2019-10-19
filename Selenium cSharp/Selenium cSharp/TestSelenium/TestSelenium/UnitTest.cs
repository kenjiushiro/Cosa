using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestSelenium
{
    class UnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\chromedriver");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.comn";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
