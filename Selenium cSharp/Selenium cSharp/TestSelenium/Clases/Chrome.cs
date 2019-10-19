using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Text.RegularExpressions;

namespace Clases
{
    public class Chrome
    {
        #region Atributos y constructores

        private IWebDriver driver;
        ChromeOptions options;
        ICapabilities capabilities;

        public Chrome(string chromedriverDirectory)
        {
            options = new ChromeOptions();
            SetOptions();
            driver = new ChromeDriver(chromedriverDirectory,options);
            capabilities = ((RemoteWebDriver)driver).Capabilities;
            driver.Manage().Window.Maximize();
        }
        public Chrome(string chromedriverDirectory, string url) : this(chromedriverDirectory)
        {
            driver.Url = url;
        }

        private void SetOptions()
        {
            options.AddArgument(@"user-data-dir=C:\SeleniumProfiles\Default");
            options.LeaveBrowserRunning = true;

        }

        #endregion

        #region Propiedades

        public string ChromeVersion
        {
            get
            {
                return options.BrowserVersion;
            }
        } 

        public string BrowserName
        {
            get
            {
                return options.BrowserName;
            }
        }

        public string URL
        {
            set
            {
                driver.Url = value;
            }
        }


        public string DriverVersion
        {
            get
            {
                string pattern = "[0-9]{2}";
                string input;
                string version;
                input = (string)(capabilities.GetCapability("chrome") as Dictionary<string, object>)["chromedriverVersion"];
                Match m = Regex.Match(input, pattern);
                version = m.ToString();
                
                return version;
            }
        }
        #endregion

        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }

        public void Close()
        {
            driver.Close();
            driver.Dispose();
        }




    }
}
