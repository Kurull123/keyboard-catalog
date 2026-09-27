using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fConnection : Form
    {
        string userRole;
        public fConnection(string role)
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
                типПідключенняBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void типПідключенняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типПідключенняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void fConnection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyboardsDataSet.ТипПідключення' table. You can move, or remove it, as needed.
            this.типПідключенняTableAdapter.Fill(this.keyboardsDataSet.ТипПідключення);
            DataRow dr = keyboardsDataSet.Tables["ТипПідключення"].Rows[типПідключенняBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
        }

        private void типПідключенняDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ТипПідключення"].Rows[типПідключенняBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            типПідключенняBindingSource.Position--;
            DataRow dr = keyboardsDataSet.Tables["ТипПідключення"].Rows[типПідключенняBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            типПідключенняBindingSource.Position++;
            DataRow dr = keyboardsDataSet.Tables["ТипПідключення"].Rows[типПідключенняBindingSource.Position];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ТипПідключення"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox1.Text;
            dr[2] = textBox1.Text;
            keyboardsDataSet.Tables["ТипПідключення"].Rows.Add(dr);
             this.Validate();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["ТипПідключення"].Rows[типПідключенняBindingSource.Position];
            dr.Delete();
            this.Validate();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типПідключенняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);
        }

        private void btnMultiSearch_Click(object sender, EventArgs e)
        {
            string type = textBoxConnType.Text;
            string interfaceName = textBoxInterface.Text;
            типПідключенняBindingSource.Filter = string.Format("[Тип підключення] LIKE '%{0}%' AND Інтерфейс LIKE '%{1}%'", type, interfaceName);
        }
    }
}
