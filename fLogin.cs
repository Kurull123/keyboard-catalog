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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        public string role = ""; // Сюди запишемо роль після успішного входу

        private void button1_Click(object sender, EventArgs e)
        {
            this.users_TableAdapter.Fill(this.keyboardsDataSet.Users_);

            DataRow[] res = this.keyboardsDataSet.Users_.Select(
                string.Format("Login_ = '{0}' AND Password_ = '{1}'", textBox1.Text, textBox2.Text)
            );

            if (res.Length > 0)
            {
                role = res[0]["Role_"].ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong login/password");
            }
        }

        private void users_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.keyboardsDataSet);

        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyboardsDataSet.Users_' table. You can move, or remove it, as needed.
            this.users_TableAdapter.Fill(this.keyboardsDataSet.Users_);

        }
    }
}
