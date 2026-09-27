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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class fManufacturer : Form
    {
        string userRole;
        int findrow = 0;
        public fManufacturer(string role)
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
                виробникBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void виробникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виробникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void fManufacturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyboardsDataSet.Виробник' table. You can move, or remove it, as needed.
            this.виробникTableAdapter.Fill(this.keyboardsDataSet.Виробник);
            DataRow dr = keyboardsDataSet.Tables["Виробник"].Rows[виробникBindingSource.Position];
            textBox5.Text = dr[0].ToString();
            textBox6.Text = dr[1].ToString();
            textBox7.Text = dr[2].ToString();
            textBox8.Text = dr[3].ToString();
        }

        private void виробникDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["Виробник"].Rows[виробникBindingSource.Position];
            textBox5.Text = dr[0].ToString();
            textBox6.Text = dr[1].ToString();
            textBox7.Text = dr[2].ToString();
            textBox8.Text = dr[3].ToString();
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            виробникBindingSource.Position--;
            DataRow dr = keyboardsDataSet.Tables["Виробник"].Rows[виробникBindingSource.Position];
            textBox5.Text = dr[0].ToString();
            textBox6.Text = dr[1].ToString();
            textBox7.Text = dr[2].ToString();
            textBox8.Text = dr[3].ToString();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            виробникBindingSource.Position++;
            DataRow dr = keyboardsDataSet.Tables["Виробник"].Rows[виробникBindingSource.Position];
            textBox5.Text = dr[0].ToString();
            textBox6.Text = dr[1].ToString();
            textBox7.Text = dr[2].ToString();
            textBox8.Text = dr[3].ToString();
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["Виробник"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            keyboardsDataSet.Tables["Виробник"].Rows.Add(dr);
             this.Validate();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["Виробник"].Rows[виробникBindingSource.Position];
            dr.Delete();
            this.Validate();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виробникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);
        }

        void FindManufacturer()
        {
            for (int i = findrow + 1; i < keyboardsDataSet.Tables["Виробник"].Rows.Count; i++)
            {
                if (keyboardsDataSet.Tables["Виробник"].Rows[i][1].ToString().Contains(textBoxFindManuf.Text))
                {
                    виробникBindingSource.Position = i;
                    findrow = i;
                    return;
                }
            }
            MessageBox.Show("No more matches");
        }

        private void btnFindFirst_Click(object sender, EventArgs e)
        {
            findrow = -1;
            FindManufacturer();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            FindManufacturer();
        }
    }
}
