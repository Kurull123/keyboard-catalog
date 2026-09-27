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

namespace WindowsFormsApp1
{
    public partial class fSize : Form
    {
        string userRole;
        public fSize(string role)
        {
            InitializeComponent();
            userRole = role;
            if (userRole != "Admin")
            {
                bAddNew.Enabled = false;
                bDelete.Enabled = false;
                bSave.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                формФакторBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void формФакторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.формФакторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void fSize_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyboardsDataSet.ФормФактор' table. You can move, or remove it, as needed.
            this.формФакторTableAdapter.Fill(this.keyboardsDataSet.ФормФактор);
            DataRow dr = keyboardsDataSet.Tables["ФормФактор"].Rows[формФакторBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
        }

        private void формФакторDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ФормФактор"].Rows[формФакторBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            формФакторBindingSource.Position--;
            DataRow dr = keyboardsDataSet.Tables["ФормФактор"].Rows[формФакторBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            формФакторBindingSource.Position++;
            DataRow dr = keyboardsDataSet.Tables["ФормФактор"].Rows[формФакторBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ФормФактор"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox1.Text;
            keyboardsDataSet.Tables["ФормФактор"].Rows.Add(dr);
             this.Validate();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ФормФактор"].Rows[формФакторBindingSource.Position];
            dr.Delete();
             this.Validate();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.формФакторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);
        }

        private void btnSearchPK_Click(object sender, EventArgs e)
        {
            int index = формФакторBindingSource.Find("Код", textBoxPKFind.Text);

            if (index > -1)
            {
                формФакторBindingSource.Position = index;
            }
            else
            {
                MessageBox.Show("Unknown");
            }
        }
    }
}
