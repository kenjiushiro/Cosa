﻿using System;
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
using OpenQA.Selenium.Support.Events;
using System.Threading;
using System.IO;
using System.Windows;
using Polly;

namespace Clases
{
    public class Chrome<T>
    {
        #region Atributos y constructores

        public delegate void Delegado(string aviso);
        public event Delegado CambioElemento;
        Thread openBrowser;

        //Queue de elementos a procesar
        protected static Queue<T> elementos;

        //Variables del webdriver
        private string url;
        private IWebDriver driver;
        ChromeOptions options;
        ICapabilities capabilities;

        //True si hay que usar la sesion del usuario o false si es una nueva
        private bool recoverUserSession;


        protected void EventoCambio(string textoAviso)
        {
            CambioElemento(textoAviso);
        }

        public Chrome(string chromeDriverPath,int nada)
        {
            ChromeOptions options = new ChromeOptions();
            string chromeDriverDirectory = Path.GetDirectoryName(chromeDriverPath);
            options.DebuggerAddress = "127.0.0.1:62882";
            var policy = Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(10, t => TimeSpan.FromSeconds(1));

            policy.Execute(() =>
            {
                driver = new ChromeDriver(chromeDriverDirectory, options);
                driver.Url = "https://www.google.com";
            });
        }

        public Chrome(string chromedriverPath,bool userSession)
        {
            string chromedriverDirectory="";

            options = new ChromeOptions();
            recoverUserSession = userSession;
            SetOptions();
            if (!File.Exists(chromedriverPath))
            {
                throw new FileNotFoundException("Chromedriver could not be found");
            }
            chromedriverDirectory = Path.GetDirectoryName(chromedriverPath);
            try
            {
                driver = new ChromeDriver(chromedriverDirectory,options);
            }
            catch(Exception ex)
            {
                throw new InvalidCastException("The chromedriver is not valid. Please download the chromedriver from\nhttps://chromedriver.chromium.org/");
            }

            capabilities = ((RemoteWebDriver)driver).Capabilities;
            driver.Manage().Window.Maximize();
        }

        public Chrome(string chromedriverPath) :this(chromedriverPath, true)
        {

        }

        public Chrome(string chromedriverPath, string url) : this(chromedriverPath, true)
        {
            this.url = url;
        }

        public Chrome(string chromedriverPath, string url,bool userSession):this(chromedriverPath, userSession)
        {
            this.url = url;
            this.recoverUserSession = userSession;
        }

        /// <summary>
        /// Creates a new thread to open the website
        /// </summary>
        public void StartDriver()
        {
            openBrowser = new Thread(this.OpenDriver);
            openBrowser.Start();
            //OpenDriver();
        }

        private void OpenDriver()
        {
            driver.Url = this.url;

        }

        private void SetOptions()
        {
            if(this.recoverUserSession)
                options.AddArgument(@"user-data-dir=C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Google\\Chrome\\User Data\\");
            options.LeaveBrowserRunning = true;
        }

        public static void KillTask(string processName)
        {
            Process[] procesos = Process.GetProcesses();
            foreach(Process proceso in procesos)
                if(processName == proceso.ProcessName)
                {
                    //Debug.Print(proceso.ProcessName);
                    proceso.Kill();
                }
            
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Setea o recupera la Queue de elementos a procesar
        /// </summary>
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

        /// <summary>
        /// Retorna el proximo elemento en la queue sin sacarlo de la lista
        /// </summary>
        public virtual T NextElement
        {
            get
            {
                return elementos.Peek();
            }
        }

        /// <summary>
        /// Retorna true si la queue esta inicializada
        /// </summary>
        public static bool QueueCreated
        {
            get
            {
                if (elementos != null)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Retorna la version del chromedriver
        /// </summary>
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


        /// <summary>
        /// Retorna la version de Google Chrome
        /// </summary>
        public static string ChromeVersion
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

        //public string BrowserName
        //{
        //    get
        //    {

        //        return options.BrowserName;
                
        //    }
        //}

        /// <summary>
        /// Abre una pagina pasandole una URL
        /// </summary>
        public string URL
        {
            set
            {
                driver.Url = value;
            }
        }

        /// <summary>
        /// Retorna el webdriver
        /// </summary>
        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }

        /// <summary>
        /// Retorna el texto de una alerta
        /// </summary>
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
        /// <summary>
        /// Cierra el chromedriver y libera el espacio en memoria
        /// </summary>
        public void Close()
        {
            //driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        /// <summary>
        /// Acepta la alerta de javascript
        /// </summary>
        public void AcceptAlert()
        {
            IAlert a;
            a = this.driver.SwitchTo().Alert();
            a.Accept();
        }


        /// <summary>
        /// Cierra la alerta de javascript
        /// </summary>
        public void DismissAlert()
        {
            IAlert a = this.driver.SwitchTo().Alert();
            a.Dismiss();
        }

        /// <summary>
        /// Ejecuta una funcion en javascript
        /// </summary>
        /// <param name="jsFunction"></param>
        public void ExecuteJavascriptFunction(string jsFunction)
        {
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)this.Driver;
            javaScript.ExecuteScript(jsFunction);
        }
        

        public void LaunchBrowser_Click(object sender, RoutedEventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            proc.StartInfo.Arguments = "https://www.intellitect.com/blog/ --new-window --remote-debugging-port=9222 --user-data-dir=C:\\Temp";
            proc.Start();
        }


        #endregion
    }
}
