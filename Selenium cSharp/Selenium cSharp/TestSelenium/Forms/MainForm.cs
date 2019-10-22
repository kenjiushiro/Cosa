using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Clases;
using Archivos;
using Excepciones;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using SUGUS;
using System.Net.Http;
using System.Diagnostics;

namespace Forms
{
    public partial class chromedriverSelector : Form
    {
        //Files chromedriver y excel parameters
        static AppDataFile<string> chromedriverFile;
        static AppDataFile<ExcelParameters> excelParametersFile;


        public delegate void DelegadoLabel(string texto);
        string version;
        sugusParametersForm sugusParameters;
        protected ExcelParameters excelParameters;
        MyScheduling myScheduling;
        Thread bot;

        public chromedriverSelector()
        {
            InitializeComponent();
        }

        public string InputFile
        {
            get
            {
                return this.txtInputFile.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            version = "3.6.5";
            this.txtBotName.Text = "SUGUS";
            Icon icon = new Icon(Environment.CurrentDirectory + "\\robotIcon.ico");
            this.Icon = icon;
            excelParametersFile = new BinaryFile<ExcelParameters>("SUGUS", "parameters.bin");
            chromedriverFile = new TxtFile("SUGUS", "chromedriverPath.txt");
            radioNew.Checked = true;
            try
            {
                txtChromedriverPath.Text = chromedriverFile.ReadFile();
                excelParameters = excelParametersFile.ReadFile();
            }
            catch(Exception ex)
            {
                if (ex is SerializationException || ex is FileNotFoundException)
                    excelParameters = new ExcelParameters("", "InputFile", 1);
                else
                    throw ex;
            }
            txtInputFile.Text = excelParameters.Path;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtChromedriverPath.Text =  dialog.FileName;
            }
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void LblInstrucciones_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivos();
        }

        public void GuardarArchivos()
        {
            chromedriverFile.WriteFile(txtChromedriverPath.Text);
            if (sugusParameters != null)
                this.excelParameters = sugusParameters.eParameters;
            excelParametersFile.WriteFile(this.excelParameters);
            MessageBox.Show("Settings saved!");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {   
            
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            //CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            //dialog.InitialDirectory = "C:\\Users";
            //dialog.IsFolderPicker = false;
            //if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            //{
            //    txtInputFile.Text = dialog.FileName;
            //    this.excelParameters.Path = dialog.FileName;
            //}


            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files| *.xls; *.xlsx; *.xlsm";
            dialog.InitialDirectory = "C:\\";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = dialog.FileName;
                this.excelParameters.Path = dialog.FileName;
            }
        }

        private void BtnFileParameters_Click(object sender, EventArgs e)
        {
            if(sugusParameters==null)
            {
                sugusParameters = new sugusParametersForm(excelParameters);
            }
            sugusParameters.Show();
            
        }

        private void BtnDriverVersion_Click(object sender, EventArgs e)
        {
            string chromedriverVersion;
            string browserVersion;
            if (File.Exists(this.txtChromedriverPath.Text + "\\chromedriver.exe"))
                if (myScheduling == null)
                {
                    myScheduling = new MyScheduling(txtChromedriverPath.Text, false);
                    chromedriverVersion = myScheduling.DriverVersion;
                    browserVersion = myScheduling.ChromeVersion;
                    myScheduling.Close();
                    MessageBox.Show("Chromedriver version: " + chromedriverVersion + "\n" + "Chrome browser version: " + browserVersion);
                }
                else
                {
                    chromedriverVersion = myScheduling.DriverVersion;
                    browserVersion = myScheduling.ChromeVersion;
                    MessageBox.Show("Chromedriver version: " + chromedriverVersion + "\n" + "Chrome browser version: " + browserVersion);
                }
            else
                MessageBox.Show("The chromedriver could not be found at the specified location");




        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

        }


        private void BtnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                bot.Abort();
            }
            catch(Exception ex)
            {
                if (!(ex is System.NullReferenceException))
                {
                    bot.Resume();
                    
                }
                else
                    MessageBox.Show("The bot is not running");
            }
            finally
            {
                myScheduling.Close();
                this.progressBar1.Value = 0;
            }
        }


        private void BtnRunBot_Click(object sender, EventArgs e)
        {
            //myScheduling = new MyScheduling(txtChromedriverPath.Text, "https://myscheduling.accenture.com/ProjectExec#/home");
            if(Validar())
            {
                if(radioNew.Checked)
                    myScheduling = new MyScheduling(txtChromedriverPath.Text, "https://www.google.com",false);
                else
                    myScheduling = new MyScheduling(txtChromedriverPath.Text, "https://www.google.com");
                myScheduling.StartDriver();
                myScheduling.CambioElemento += CambiarLabelItem;
                if(!MyScheduling.QueueCreated)
                    MyScheduling.LeerData(excelParameters.Path, excelParameters.SheetName);
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = MyScheduling.Elementos.Count;
                bot = new Thread(myScheduling.DoStuff);
                bot.Start();
            }
        }

        private void BtnThreadState_Click(object sender, EventArgs e)
        {
            if(bot!=null && bot.IsAlive)
                MessageBox.Show("Running");
            else
                MessageBox.Show("Ded");
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (bot != null && bot.IsAlive)
                try
                {
                    bot.Resume();
                }
                catch(Exception)
                {
                    MessageBox.Show("The bot is already running");
                }
            else
                MessageBox.Show("The bot is not running");
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (bot != null && bot.IsAlive)
                try
                {
                    bot.Suspend();
                }
                catch(Exception)
                {
                  
                }
            else
                MessageBox.Show("The bot is not running");




        }

        private void BtnBmf_Click(object sender, EventArgs e)
        {
            Queue<RolDemanda> roles = MyScheduling.Elementos;
            foreach(RolDemanda rol in roles)
            {
                Debug.Print(rol.ToString()); 
            }
        }

        private void BtnAlertAccept_Click(object sender, EventArgs e)
        {
            try
            {
                myScheduling.AcceptAlert();
            }
            catch(Exception)
            {
                MessageBox.Show("Alert not found");
            }
        }

        private void BtnAlertDismiss_Click(object sender, EventArgs e)
        {
            try
            {
                myScheduling.DismissAlert();
            }
            catch(Exception)
            {
                MessageBox.Show("Alert not found");
            }
        }


        private void BtnAlertRead_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(myScheduling.Alerta);
            }
            catch(Exception)
            {
                MessageBox.Show("Alert not found");
            }
        }

        private void BtnPeek_Click(object sender, EventArgs e)
        {
            if (bot != null && bot.IsAlive)
                MessageBox.Show(myScheduling.NextElement + "");
            else
                MessageBox.Show("The bot is not running");
        }

        public void CambiarLabelItem(string texto)
        {
            if (this.lblProgress.InvokeRequired)
            {
                this.lblProgress.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblProgress.Text = texto;
                    this.progressBar1.Value++;
                }
                );
            }
            else
            {
                this.lblProgress.Text = texto;
            }
        }

        public void CambiarLabelState(string texto)
        {
            if (this.lblState.InvokeRequired)
            {
                this.lblState.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblState.Text = texto;
                }
                );
            }
            else
            {
                this.lblState.Text = texto;
            }
        }

        private void BtnShowData_Click(object sender, EventArgs e)
        {
            if (!MyScheduling.QueueCreated)
                MessageBox.Show("File was not read yet");
            else
            {
                FormMostrarElementos formElementos = new FormMostrarElementos();
                foreach (RolDemanda rol in MyScheduling.Elementos)
                {
                    formElementos.AddItem(rol.ID, rol.Cliente, rol.Specialty);
                }
                formElementos.AddHeader("ID");
                formElementos.AddHeader("Cliente");
                formElementos.AddHeader("Specialty");
                formElementos.Show();
            }
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            if (!MyScheduling.QueueCreated)
            {
                CambiarLabelState("Reading excel");
                MessageBox.Show(MyScheduling.LeerData(excelParameters.Path, excelParameters.SheetName));
            }
            else
                if(MessageBox.Show("Discard loaded data?","A file was already loaded", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CambiarLabelState("Reading excel");
                    MessageBox.Show(MyScheduling.LeerData(excelParameters.Path, excelParameters.SheetName));
                }
            CambiarLabelState("Ready");
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(progressBar1.Value + " out of " + progressBar1.Maximum);
        }

        private void ContextMenuValidar_Opening(object sender, CancelEventArgs e)
        {
        }

        private void ValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Validar())
                MessageBox.Show("Chromedriver and excel file were found successfuly");
            
        }
            
        private bool Validar()
        {
            StringBuilder mensaje = new StringBuilder();
            bool retorno = true;

            Excel excel;
            try
            {
                excel = new Excel(excelParameters.Path, excelParameters.SheetName);
            }
            catch(Exception ex )
            {
                retorno = false;
                if (ex is FileNotFoundException || ex is WorkbookNotFound || ex is WorksheetNotFound)
                    mensaje.AppendLine(ex.Message);
                else
                    MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            //this.txtChromedriverPath.Text 
            if (!File.Exists(this.txtChromedriverPath.Text + "\\chromedriver.exe"))
            {
                mensaje.AppendLine("Chromedriver file could not be found in the specified location");
                retorno = false;
            }
            if(!retorno)
                MessageBox.Show(mensaje.ToString());
                
            return retorno;
        }

        private void BtnKillTaskChrome_Click(object sender, EventArgs e)
        {
            MyScheduling.KillTask("chrome");
        }

        private void BtnKillTaskChromedriver_Click(object sender, EventArgs e)
        {
            MyScheduling.KillTask("chromedriver");
        }

        private void BtnCheckUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                WebScraper ws = new WebScraper("http://localhost:8000");
                //WebScraper ws = new WebScraper("http://www.gooasdsaasdgle.com");
                string botVersion;
                try
                {
                    botVersion = ws.GetTextByID(this.txtBotName.Text).Trim();
                    if (botVersion == version)
                        MessageBox.Show("The bot is up to date");
                    else
                        MessageBox.Show("There is a new version available (" + botVersion + ")");
                }
                catch(Exception)
                {
                    MessageBox.Show("The bot was not found");
                }
            }
            catch(WebsiteWasNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnShowAlert_Click(object sender, EventArgs e)
        {
            myScheduling.ExecuteJavascriptFunction("alert('asdsadsadsa')");

        }
    }
}
