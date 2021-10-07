//25.Если в первом столбце двумерного массива A все элементы по модулю 
//больше заданной величины, разделить столбец с максимальным средним 
//арифметическим элементов на соответствующие элементы первого 
//столбца.

using System;

namespace laba1
{
    class Program
    {
        // Ввод матрицы и начального значения
        public static void Input(out double[,] x, out double y)
        {
            Console.Write("Введите число\nВвод: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размеры двумерного массива\nВвод: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]),
                m = Convert.ToInt32(input[1]);
            if (n <= 0 || m <= 0) throw new ArgumentOutOfRangeException();
            x = new double[n, m];
            Console.WriteLine("Заполнение массива");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.Write("Ввод: ");
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < x.GetLength(1); j++)
                    x[i, j] = Convert.ToDouble(input[j]);
            }

        }

        // Проверка условия, что все элементы первого столбца больше по модулю заданного числа.
        public static bool Condition(double[,] x, double c)
        {
            bool isMore = true;
            for(int i = 0; i < x.GetLength(0); i++)
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
            int  colMax = 0, n = x.GetLength(0);
            for (int i = 0; i < x.GetLength(1); i++)
            {
                double sum = 0, average;
                for(int j = 0; j < n; j++)
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
            for(int i = 0; i < x.GetLength(0); i++)
            {
                if (x[i, 0] == 0) throw new DivideByZeroException();
                x[i, colMax] = x[i, colMax] / x[i, 0];
            }
        }
        // Вывод матрицы.
        public static void MatrixOutput(double[,] x)
        {
            Console.WriteLine("Результ. матрица:");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                    Console.Write("{0:F4} ",x[i,j]);
                Console.WriteLine();
            }
                
        }
        static void Main(string[] args)
        {
            try
            {
                Input(out double[,] a, out double c);
                if (Condition(a, c))
                    MatrixTransformation(a);
                else
                    Console.WriteLine("Условие не выполнено");
                MatrixOutput(a);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка! Деление на ноль.");
            }
            catch(Exception ex) when (ex is IndexOutOfRangeException || ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка! Недопустимый ввод.");
            }
        }
    }
}
