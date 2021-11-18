using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class FormDialog : Form
    {
        public Form1 form1;
        public FormDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.rb1 = radioButton1.Checked;
            Form1.rb2 = radioButton2.Checked;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.menuDialog.Enabled = true;
        }
    }
}
