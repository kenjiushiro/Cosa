using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FormMostrarElementos : Form
    {
        public FormMostrarElementos()
        {
            InitializeComponent();
        }

        private void ListViewElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMostrarElementos_Load(object sender, EventArgs e)
        {
        }
        
        public void AddItem(string id,string cliente, string specialty)
        {
            ListViewItem item1 = new ListViewItem(id,0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add(cliente);
            item1.SubItems.Add(specialty);
            listviewElementos.Items.Add(item1);
        }

        public void AddHeader(string header)
        {
            listviewElementos.Columns.Add(header);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
