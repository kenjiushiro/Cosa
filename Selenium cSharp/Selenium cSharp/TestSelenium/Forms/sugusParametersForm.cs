using Archivos;
using Clases;
using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class sugusParametersForm : Form
    {
        ExcelParameters excelParameters;

        public sugusParametersForm(ExcelParameters excelParameters)
        {
            InitializeComponent();
            this.excelParameters = excelParameters;
        }

        public ExcelParameters eParameters
        {
            get
            {
                return this.excelParameters;
            }
        }

        private void SugusParametersForm_Load(object sender, EventArgs e)
        {
            this.txtSheetname.Text = excelParameters.SheetName;
            this.numericHeaderRow.Value = excelParameters.HeaderRow;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            excelParameters.SheetName = this.txtSheetname.Text;
            excelParameters.HeaderRow = (int)this.numericHeaderRow.Value;
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
