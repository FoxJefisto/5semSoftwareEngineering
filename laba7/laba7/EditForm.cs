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
    public partial class EditForm : Form
    {
        delegate bool MyDelegate(List<Archipelago> lst);


        public EditForm()
        {
            InitializeComponent();
            if (Data.lst.Count != 0)
            {
                tb1.Text = Data.lst[0].name;
                tb2.Text = Convert.ToString(Data.lst[0].nIslands);
                tb3.Text = Convert.ToString(Data.lst[0].nHabitableIslands);
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnSolve.Enabled = true;
                if (Data.lst.Count > 1)
                    btnForward.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnForward.Enabled = true;
            Data.i--;
            tb1.Text = Data.lst[Data.i].name;
            tb2.Text = Convert.ToString(Data.lst[Data.i].nIslands);
            tb3.Text = Convert.ToString(Data.lst[Data.i].nHabitableIslands);
            if (Data.i == 0)
            {
                btnBack.Enabled = false;
            }
            if (Data.lst.Count == 1)
            {
                btnForward.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            Data.i++;
            tb1.Text = Data.lst[Data.i].name;
            tb2.Text = Convert.ToString(Data.lst[Data.i].nIslands);
            tb3.Text = Convert.ToString(Data.lst[Data.i].nHabitableIslands);

            if (Data.i == Data.lst.Count - 1)
            {
                btnForward.Enabled = false;
            }

            if (Data.lst.Count == 1)
            {
                btnBack.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Data.i != Data.lst.Count - 1)
                btnForward_Click(null, null);
            if (Data.i == Data.lst.Count - 1 && Data.lst.Count != 1)
                btnBack_Click(null, null);
            if (Data.lst.Count == 1)
            {
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnSolve.Enabled = false;
            }
            Data.lst.RemoveAt(Data.i);
            if (Data.lst.Count == 1)
            {
                btnBack.Enabled = false;
                btnForward.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name;
            int nIslands, nHabitableIslands;
            if (!string.IsNullOrWhiteSpace(tb1.Text) && int.TryParse(tb2.Text, out nIslands) && int.TryParse(tb3.Text, out nHabitableIslands))
            {
                if(nHabitableIslands <= nIslands)
                {
                    name = tb1.Text;
                    Data.lst[Data.i].name = name;
                    Data.lst[Data.i].nIslands = nIslands;
                    Data.lst[Data.i].nHabitableIslands = nHabitableIslands;
                }
                else
                {
                    MessageBox.Show(
                            "Количество обитаемых островов больше, чем общее количество островов!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show(
                            "Введены не все данные!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show();
        }
    }
}
