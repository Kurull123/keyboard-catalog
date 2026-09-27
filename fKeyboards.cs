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
    public partial class fKeyboards : Form
    {
        string userRole;
        public fKeyboards(string role)
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
                клавіатуриBindingNavigatorSaveItem.Enabled = false;
                клавіатуриDataGridView.ReadOnly = true;
            }
        }

        private void fKeyboards_Load(object sender, EventArgs e)
        {
            this.типПідключенняTableAdapter.Fill(this.keyboardsDataSet.ТипПідключення);
            // TODO: This line of code loads data into the 'keyboardsDataSet.ФормФактор' table. You can move, or remove it, as needed.
            this.формФакторTableAdapter.Fill(this.keyboardsDataSet.ФормФактор);
            // TODO: This line of code loads data into the 'keyboardsDataSet.ТипКлавіатури' table. You can move, or remove it, as needed.
            this.типКлавіатуриTableAdapter.Fill(this.keyboardsDataSet.ТипКлавіатури);
            // TODO: This line of code loads data into the 'keyboardsDataSet.Виробник' table. You can move, or remove it, as needed.
            this.виробникTableAdapter.Fill(this.keyboardsDataSet.Виробник);
            // TODO: This line of code loads data into the 'keyboardsDataSet.Клавіатури' table. You can move, or remove it, as needed.
            this.клавіатуриTableAdapter.Fill(this.keyboardsDataSet.Клавіатури);
            DataRow dr = keyboardsDataSet.Tables["Клавіатури"].Rows[клавіатуриBindingSource.Position];
            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr[1].ToString();
            comboBox5.Text = dr[2].ToString();
            comboBox6.Text = dr[3].ToString();
            comboBox7.Text = dr[4].ToString();
            textBox3.Text = dr[5].ToString();
            comboBox8.Text = dr[6].ToString();
            textBox4.Text = dr[7].ToString();
            checkBox1.Checked = Convert.ToBoolean(dr[8]);
            textBox5.Text = dr[9].ToString();
            textBox6.Text = dr[10].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            клавіатуриBindingSource.Position--;
            DataRow dr = keyboardsDataSet.Tables["Клавіатури"].Rows[клавіатуриBindingSource.Position];
            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr[1].ToString();
            comboBox5.Text = dr[2].ToString();
            comboBox6.Text = dr[3].ToString();
            comboBox7.Text = dr[4].ToString();
            textBox3.Text = dr[5].ToString();
            comboBox8.Text = dr[6].ToString();
            textBox4.Text = dr[7].ToString();
            checkBox1.Checked = Convert.ToBoolean(dr[8]);
            textBox5.Text = dr[9].ToString();
            textBox6.Text = dr[10].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            клавіатуриBindingSource.Position++;
            DataRow dr = keyboardsDataSet.Tables["Клавіатури"].Rows[клавіатуриBindingSource.Position];
            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr[1].ToString();
            comboBox5.Text = dr[2].ToString();
            comboBox6.Text = dr[3].ToString();
            comboBox7.Text = dr[4].ToString();
            textBox3.Text = dr[5].ToString();
            comboBox8.Text = dr[6].ToString();
            textBox4.Text = dr[7].ToString();
            checkBox1.Checked = Convert.ToBoolean(dr[8]);
            textBox5.Text = dr[9].ToString();
            textBox6.Text = dr[10].ToString();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клавіатуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["Клавіатури"].Rows[клавіатуриBindingSource.Position];
            dr.Delete();
             this.Validate();
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["Клавіатури"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = comboBox5.Text;
            dr[3] = comboBox6.Text;
            dr[4] = comboBox7.Text;
            dr[5] = textBox3.Text;
            dr[6] = comboBox8.Text;
            dr[7] = textBox4.Text;
            dr[8] = checkBox1.Checked;
            dr[9] = textBox5.Text;
            dr[10] = textBox6.Text;
            keyboardsDataSet.Tables["Клавіатури"].Rows.Add(dr);
            this.Validate();
        }

        private void клавіатуриDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = keyboardsDataSet.Tables["Клавіатури"].Rows[клавіатуриBindingSource.Position];
            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr[1].ToString();
            comboBox5.Text = dr[2].ToString();
            comboBox6.Text = dr[3].ToString();
            comboBox7.Text = dr[4].ToString();
            textBox3.Text = dr[5].ToString();
            comboBox8.Text = dr[6].ToString();
            textBox4.Text = dr[7].ToString();
            checkBox1.Checked = Convert.ToBoolean(dr[8]);
            textBox5.Text = dr[9].ToString();
            textBox6.Text = dr[10].ToString();
        }

        private void btnSearchPK_Click(object sender, EventArgs e)
        {
            int index = клавіатуриBindingSource.Find("Код", textBoxPKFind.Text);

            if (index > -1)
            {
                клавіатуриBindingSource.Position = index;
            }
            else
            {
                MessageBox.Show("Unknown");
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilter.Text))
            {
                клавіатуриBindingSource.RemoveFilter();
            }
            else
            {
                клавіатуриBindingSource.Filter = string.Format("Назва LIKE '%{0}%'", textBoxFilter.Text);
            }
        }

        private void клавіатуриBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.клавіатуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void клавіатуриBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.клавіатуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void клавіатуриBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клавіатуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void textBoxFilter2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilter2.Text))
            {
                клавіатуриBindingSource.RemoveFilter();
            }
            else
            {
                DataRow[] matches = keyboardsDataSet.Виробник.Select(string.Format("Назва LIKE '%{0}%'", textBoxFilter2.Text));

                if (matches.Length > 0)
                {
                    var ids = matches.Select(row => row["Код"].ToString());
                    string inClause = string.Join(", ", ids);

                    клавіатуриBindingSource.Filter = string.Format("Виробник IN ({0})", inClause);
                }
                else
                {
                    клавіатуриBindingSource.Filter = "Convert(Виробник, 'System.Int32') = -1";
                }
            }
        }

        private void textBoxFilter3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilter3.Text))
            {
                клавіатуриBindingSource.RemoveFilter();
            }
            else
            {
                клавіатуриBindingSource.Filter = string.Format("Розкладка LIKE '%{0}%'", textBoxFilter3.Text);
            }
        }

        private void textBoxFilter4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilter4.Text))
            {
                клавіатуриBindingSource.RemoveFilter();
            }
            else
            {
                клавіатуриBindingSource.Filter = string.Format("Перемикачі LIKE '%{0}%'", textBoxFilter4.Text);
            }
        }

        private void textBoxFilter5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilter5.Text))
            {
                клавіатуриBindingSource.RemoveFilter();
            }
            else
            {
                клавіатуриBindingSource.Filter = string.Format("Колір LIKE '%{0}%'", textBoxFilter5.Text);
            }
        }
    }
}
