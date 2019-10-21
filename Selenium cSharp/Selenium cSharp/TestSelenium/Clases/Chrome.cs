using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Microsoft.Win32;

namespace Clases
{
    public class Chrome<T>
    {
        #region Atributos y constructores
        public delegate void Delegado(string aviso);
        public event Delegado CambioElemento;

        protected static Queue<T> elementos;
        private IWebDriver driver;
        ChromeOptions options;
        ICapabilities capabilities;
        private bool recoverUserSession;

        protected void EventoCambio(string textoAviso)
        {
            CambioElemento(textoAviso);
        }

        public Chrome(string chromedriverDirectory,bool userSession)
        {
            options = new ChromeOptions();
            recoverUserSession = userSession;
            SetOptions();
            driver = new ChromeDriver(chromedriverDirectory,options);
            capabilities = ((RemoteWebDriver)driver).Capabilities;
            driver.Manage().Window.Maximize();
        }

        public Chrome(string chromedriverDirectory):this(chromedriverDirectory,true)
        {

        }

        public Chrome(string chromedriverDirectory, string url) : this(chromedriverDirectory,true)
        {
            driver.Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chromedriverDirectory">Location of the directory containing chromedriver.exe</param>
        /// <param name="url">URL to Open</param>
        /// <param name="userSession">True to use the current user chrome session, false to open a new one</param>
        public Chrome(string chromedriverDirectory, string url,bool userSession):this(chromedriverDirectory, userSession)
        {
            driver.Url = url;
            this.recoverUserSession = userSession;
        }

        private void SetOptions()
        {
            //options.AddArgument(@"user-data-dir=C:\SeleniumProfiles\Default");
            if(this.recoverUserSession)
                options.AddArgument(@"user-data-dir=C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Google\\Chrome\\User Data\\");
            options.LeaveBrowserRunning = true;

        }

        #endregion

        #region Propiedades
        public static Queue<T> Elementos
        {
            set
            {
                elementos = value;
            }
            get
            {
                return elementos;
            }
        }
        public virtual T NextElement
        {
            get
            {
                return elementos.Peek();
            }
        }

        public static bool QueueCreated
        {
            get
            {
                if (elementos != null)
                    return true;
                return false;
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
        public string ChromeVersion
        {
            get
            {
                string src = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

                string version = "asd";
                version = System.Diagnostics.FileVersionInfo.GetVersionInfo(src).ProductVersion.ToString();


                //object path;
                //path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe", "", null);
                //if (path != null)
                //    version = "Chrome: " + FileVersionInfo.GetVersionInfo(path.ToString()).FileVersion;

                return version;
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
        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }

        public string Alerta
        {
            get
            {
                IAlert a = driver.SwitchTo().Alert();
                return a.Text;

            }
        }

        #endregion

        #region Metodos
        
        public void Close()
        {
            //driver.Close();
            driver.Quit();
            driver.Dispose();
        }


        public void AcceptAlert()
        {
            IAlert a;
            a = this.driver.SwitchTo().Alert();
            a.Accept();
        }

        public void DismissAlert()
        {
            IAlert a = this.driver.SwitchTo().Alert();
            a.Dismiss();
        }

        #endregion
    }
}
