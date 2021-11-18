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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            int nIslands, nHabitableIslands;
            if (!string.IsNullOrWhiteSpace(tb1.Text) && int.TryParse(tb2.Text, out nIslands) && int.TryParse(tb3.Text, out nHabitableIslands))
            {
                name = tb1.Text;
                Archipelago archipelago = Archipelago.Create(name, nIslands, nHabitableIslands);
                if (archipelago != null)
                    Data.lst.Add(archipelago);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }
    }
}
