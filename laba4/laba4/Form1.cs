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
    public partial class Form1 : Form
    {
        public static bool rb1 = true;
        public static bool rb2 = false;
        public static double[,] matrix = new double[0,0];
        public Form1()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuDialog_Click(object sender, EventArgs e)
        {
            FormDialog formDialog = new FormDialog();
            formDialog.radioButton1.Checked = rb1;
            formDialog.radioButton2.Checked = rb2;
            formDialog.form1 = this;
            formDialog.Show();
        }

        private void menuInput_Click(object sender, EventArgs e)
        {
            FormInput formInput = new FormInput();
            formInput.form1 = this;
            formInput.Show();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void menuSolve_Click(object sender, EventArgs e)
        {
            FormSolve formSolve = new FormSolve();
            formSolve.form1 = this;
            formSolve.Show();
        }
    }
}
