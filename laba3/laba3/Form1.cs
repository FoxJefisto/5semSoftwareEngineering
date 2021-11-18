using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Window3 : Form
    {
        public Window3()
        {
            InitializeComponent();
            lbCondition.Text =
@"25.Если в первом столбце двумерного массива A все элементы по модулю 
больше заданной величины, разделить столбец с максимальным средним 
арифметическим элементов на соответствующие элементы первого столбца.";
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

        // Проверка условия, что все элементы первого столбца больше по модулю заданного числа.
        public static bool Condition(double[,] x, double c)
        {
            bool isMore = true;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                if (Math.Abs(x[i, 0]) <= c)
                {
                    isMore = false;
                    break;
                }
            }
            return isMore;
        }

        // Поиск столбца с наибольшим средним арифметическим.
        public static int ColumnWithMaxAverage(double[,] x)
        {
            double? maxAverage = null;
            int colMax = 0, n = x.GetLength(0);
            for (int i = 0; i < x.GetLength(1); i++)
            {
                double sum = 0, average;
                for (int j = 0; j < n; j++)
                {
                    sum += x[j, i];
                }
                average = sum / n;
                if (average > maxAverage || maxAverage == null)
                {
                    maxAverage = average;
                    colMax = i;
                }
            }
            Console.WriteLine($"Макс. сред. арифм. = {maxAverage}, найденный столбец = {colMax}");
            return colMax;
        }
        // Преобразование матрицы. Деление столбца с максимальным СА на первый столбец.
        public static void MatrixTransformation(double[,] x)
        {
            int colMax = ColumnWithMaxAverage(x);
            for (int i = 0; i < x.GetLength(0); i++)
            {
                if (x[i, 0] == 0) throw new DivideByZeroException();
                x[i, colMax] = x[i, colMax] / x[i, 0];
            }
        }

        public static double[,] ConversionGM(Window3 form1)
        {
            int n = Convert.ToInt32(form1.txtN.Text),
                m = Convert.ToInt32(form1.txtM.Text);
            double[,] x = new double[n, m];
            for(int i = 0; i < form1.Grid1.RowCount; i++)
                for(int j = 0; j < form1.Grid1.ColumnCount; j++)
                {
                    x[i,j] = Convert.ToDouble(form1.Grid1.Rows[i].Cells[j].Value);
                }
            return x;
        }

        public static void ConversionMG(Window3 form1, double[,] x)
        {
            form1.Grid2.RowCount = x.GetLength(0);
            form1.Grid2.ColumnCount = x.GetLength(1);
            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    form1.Grid2.Rows[i].Cells[j].Value = x[i,j].ToString();
                }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] a = ConversionGM(this);
                double c = Convert.ToDouble(txtC.Text);
                if (Condition(a, c))
                {
                    lbAnswer.Text = "Условие выполнено";
                    MatrixTransformation(a);
                }
                else
                    lbAnswer.Text = "Условие не выполнено";
                ConversionMG(this, a);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Попытка деления на ноль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
