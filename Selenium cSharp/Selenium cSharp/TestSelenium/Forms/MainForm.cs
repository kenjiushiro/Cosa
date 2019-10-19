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
        
        static AppDataFile<ExcelParameters> binaryFile;
        sugusParametersForm sugusParameters;
        protected ExcelParameters excelParameters;
        MyScheduling myScheduling;
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
            binaryFile = new BinaryFile<ExcelParameters>("SUGUS", "parameters.bin");
            appDataFile = new TxtFile("SUGUS", "chromedriverPath.txt");
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
            myScheduling = new MyScheduling(txtChromedriverPath.Text, "https://myscheduling.accenture.com/ProjectExec#/home");

            MessageBox.Show(myScheduling.ChromeVersion);
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
            myScheduling = new MyScheduling(txtChromedriverPath.Text);
            chromedriverVersion = myScheduling.DriverVersion;

            myScheduling.Close();
            MessageBox.Show("Chromedriver version: " + chromedriverVersion);

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myScheduling.BrowserName);
        }
    }
}
