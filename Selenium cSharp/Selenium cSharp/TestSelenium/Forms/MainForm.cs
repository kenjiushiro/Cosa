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

namespace Forms
{
    public partial class chromedriverSelector : Form
    {
        static AppDataFile<string> appDataFile;
        public delegate void DelegadoLabel(string texto);


        static AppDataFile<ExcelParameters> binaryFile;
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
            Icon icon = new Icon(Environment.CurrentDirectory + "\\robotIcon.ico");
            this.Icon = icon;
            binaryFile = new BinaryFile<ExcelParameters>("SUGUS", "parameters.bin");
            appDataFile = new TxtFile("SUGUS", "chromedriverPath.txt");
            radioNew.Checked = true;
            try
            {
                txtChromedriverPath.Text = appDataFile.ReadFile();
                excelParameters = binaryFile.ReadFile();
            }
            catch(Exception ex)
            {
                if (ex is SerializationException || ex is FileDoesNotExist)
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
            appDataFile.WriteFile(txtChromedriverPath.Text);
            if(sugusParameters!=null)
                this.excelParameters = sugusParameters.eParameters;
            binaryFile.WriteFile(this.excelParameters);
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
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
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
            catch(Exception)
            {
                bot.Resume();
            }
            finally
            {
                myScheduling.Close();
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
                myScheduling.CambioElemento += CambiarLabel;
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
            bot.Resume();
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
            MessageBox.Show(Environment.CurrentDirectory);
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




        public void CambiarLabel(string texto)
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
                MessageBox.Show(MyScheduling.LeerData(excelParameters.Path, excelParameters.SheetName));
            else
                if(MessageBox.Show("Discard loaded data?","A file was already loaded", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    MessageBox.Show(MyScheduling.LeerData(excelParameters.Path, excelParameters.SheetName));
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
            catch(Exception e )
            {
                retorno = false;
                if (e is WorkbookNotFound)
                    mensaje.AppendLine("The workbook could not be found");
                else if (e is WorksheetNotFound)
                    mensaje.AppendLine("The worksheet " + excelParameters.SheetName + " could not be found");
                else
                    MessageBox.Show(e.Message);
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
    }
}
