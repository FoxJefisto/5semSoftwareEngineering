using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            if (Data.lst.Any((a) => a.nHabitableIslands == 0))
                tb1.Text = "Да";
            else
                tb1.Text = "Нет";
        }
    }
}
