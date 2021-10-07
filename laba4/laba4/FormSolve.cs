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
    public partial class FormSolve : Form
    {
        public Form1 form1;
        private double[,] matrixModified;
        public FormSolve()
        {
            InitializeComponent();
            ConversionMG(Grid1, Form1.matrix);
            if (Form1.rb1)
            {
                matrixModified = MoveNegM(Form1.matrix);
                ConversionMG(Grid2, matrixModified);
            }
            if (Form1.rb2)
            {
                txtAnswer.Text = CountNonZeroRows(Form1.matrix).ToString();
                
            }
            txtAnswer.ReadOnly = true;
            Grid1.ReadOnly = true;
            Grid2.ReadOnly = true;
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

        public double[,] MoveNegM(double[,] x)
        {
            double[,] y = new double[x.GetLength(0), x.GetLength(1)];
            for(int i = 0; i < y.GetLength(0); i++)
            {
                int k = 0;
                for (int j = 0; j < y.GetLength(1); j++)
                    if (x[i, j] >= 0)
                        y[i, k++] = x[i, j];
                for (int j = 0; j < y.GetLength(1); j++)
                    if (x[i, j] < 0)
                        y[i, k++] = x[i, j];
            }
            return y;
        }

        public int CountNonZeroRows(double[,] x)
        {
            int k = 0;
            for(int i = 0; i < x.GetLength(0); i++)
            {
                bool zeroExist = false;
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (x[i, j] == 0)
                    {
                        zeroExist = true;
                        break;
                    }
                }
                if (!zeroExist) k++;
            }
            return k;
        }

    }
}
