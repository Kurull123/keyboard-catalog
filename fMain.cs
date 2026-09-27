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
    public partial class fMain : Form
    {
        string currentRole;
        public fMain(string userRole)
        {
            InitializeComponent();
            currentRole = userRole;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fKeyboards form2 = new fKeyboards(currentRole);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fManufacturer form3 = new fManufacturer(currentRole);
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fKeyboardType form4 = new fKeyboardType(currentRole);
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fConnection form5 = new fConnection(currentRole);
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fSize form6 = new fSize(currentRole);
            form6.ShowDialog();
        }
    }
}
