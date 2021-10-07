using System;
using System.Windows.Forms;

namespace laba4
{
    public partial class FormInput : Form
    {
        public Form1 form1;
        public FormInput()
        {
            InitializeComponent();
            txtN.Text = Form1.matrix.GetLength(0).ToString();
            txtM.Text = Form1.matrix.GetLength(1).ToString();
            ConversionMG(Grid1, Form1.matrix);
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int row))
                Grid1.RowCount = row;
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtM.Text, out int col))
                Grid1.ColumnCount = col;
        }

        public void ConversionMG(DataGridView grid, double[,] x)
        {
            grid.RowCount = x.GetLength(0);
            grid.ColumnCount = x.GetLength(1);
            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    grid.Rows[i].Cells[j].Value = x[i, j].ToString();
                }
        }
        public double[,] ConversionGM(DataGridView grid)
        {
            int n = Convert.ToInt32(txtN.Text),
                m = Convert.ToInt32(txtM.Text);
            double[,] x = new double[n, m];
            for (int i = 0; i < grid.RowCount; i++)
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    x[i, j] = Convert.ToDouble(grid.Rows[i].Cells[j].Value);
                }
            return x;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1.matrix = ConversionGM(Grid1);
            Close();
        }
    }
}
