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
    public partial class fKeyboardType : Form
    {
        string userRole;
        public fKeyboardType(string role)
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
                типКлавіатуриBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void типКлавіатуриBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типКлавіатуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void fKeyboardType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyboardsDataSet.ТипКлавіатури' table. You can move, or remove it, as needed.
            this.типКлавіатуриTableAdapter.Fill(this.keyboardsDataSet.ТипКлавіатури);
            DataRow dr = keyboardsDataSet.Tables["ТипКлавіатури"].Rows[типКлавіатуриBindingSource.Position];
            textBox3.Text = dr[0].ToString();
            textBox4.Text = dr[1].ToString();
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            типКлавіатуриBindingSource.Position--;
            DataRow dr = keyboardsDataSet.Tables["ТипКлавіатури"].Rows[типКлавіатуриBindingSource.Position];
            textBox3.Text = dr[0].ToString();
            textBox4.Text = dr[1].ToString();
        }

        private void типКлавіатуриDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ТипКлавіатури"].Rows[типКлавіатуриBindingSource.Position];
            textBox3.Text = dr[0].ToString();
            textBox4.Text = dr[1].ToString();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            типКлавіатуриBindingSource.Position++;
            DataRow dr = keyboardsDataSet.Tables["ТипКлавіатури"].Rows[типКлавіатуриBindingSource.Position];
            textBox3.Text = dr[0].ToString();
            textBox4.Text = dr[1].ToString();
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ТипКлавіатури"].NewRow();
            dr[0] = textBox3.Text;
            dr[1] = textBox4.Text;
            keyboardsDataSet.Tables["ТипКлавіатури"].Rows.Add(dr);
             this.Validate();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ТипКлавіатури"].Rows[типКлавіатуриBindingSource.Position];
            dr.Delete();
            this.Validate();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типКлавіатуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);
        }

        private void btnSearchPK_Click(object sender, EventArgs e)
        {
            int index = типКлавіатуриBindingSource.Find("Код", textBoxPKFind.Text);

            if (index > -1)
            {
                типКлавіатуриBindingSource.Position = index;
            }
            else
            {
                MessageBox.Show("Unknown");
            }
        }
    }
}
