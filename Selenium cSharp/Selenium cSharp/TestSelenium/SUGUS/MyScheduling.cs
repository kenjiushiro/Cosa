using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SUGUS
{
    public class MyScheduling : Chrome<RolDemanda>
    {
        //public delegate void Delegado(object sender, EventArgs e);
        #region Constructores

        public MyScheduling(string chromedriverPath) : base(chromedriverPath)
        {   
        }

        public MyScheduling(string chromedriverPath, bool userSession) : base(chromedriverPath, userSession)
        {
        }

        public MyScheduling(string chromedriverPath, string url) : base(chromedriverPath, url)
        {
        }

        public MyScheduling(string chromedriverPath, string url,bool userSession) : base(chromedriverPath, url,userSession)
        {
        }
        #endregion



        #region Propiedades

        #endregion

        #region Metodos
        public static void LeerData(string inputFilePath,string sheetName)
        {
            Excel excel = new Excel(inputFilePath, sheetName);
            RolDemanda rol;
            long i;
            string id;
            string cliente;
            string specialty;
            Queue<RolDemanda> roles = new Queue<RolDemanda>();

            for (i = 2; i <= 13; i++)
            {
                id = excel.Range(i, 1);
                cliente = excel.Range(i, 2);
                specialty = excel.Range(i, 3);
                rol = new RolDemanda(id, cliente, specialty);
                roles = roles + rol; 
            }
            elementos = roles;
            excel.Close();
        }





        public void DoStuff()
        {
            RolDemanda rol;
            foreach(var elemento in base.Elementos.ToList())
            {
                Thread.Sleep(1000);
                rol = base.Elementos.Dequeue();
                this.Driver.FindElement(By.Name("q")).Clear();
                base.EventoCambio(rol.ToString());
                
                //delegado(i + "");
                this.Driver.FindElement(By.Name("q")).SendKeys(rol.ID + "");
            }
        }

        #endregion
    }
}
