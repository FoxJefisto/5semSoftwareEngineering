//25.Задан целочисленный одномерный массив A из n элементов. Найти номер 
//последнего максимального элемента среди нечётных элементов,
//расположенных до последнего чётного элемента. Если нет чётных 
//элементов, искать до конца массива.

using System;

namespace laba2
{
    class BaseArray
    {
        protected int[] arr;
        private readonly int length;
        //Индексатор класса
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= length) throw new Exception("Ошибка! Недопустимый индекс.");
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= length) throw new Exception("Ошибка! Недопустимый индекс.");
                arr[index] = value;
            }
        }
        //Свойство длины
        public int Length
        {
            get
            {
                return length;
            }
        }
        //Конструторы
        public BaseArray()
        {
            arr = new int[0];
            length = 0;
        }
        public BaseArray(int n)
        {
            if (n < 0) throw new Exception("Ошибка! Нельзя задать массив отрицательной длины");
            arr = new int[n];
            length = n;
        }
        //Заполнение массива случайными элементами
        public void FillRand(int max)
        {
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next() % max;
            }
        }
        //Ввод
        public void Input()
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length < length) throw new Exception("Ошибка! Недостаточно элементов.");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }
        }
        //Вывод
        public void Print()
        {
            foreach (int x in arr)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }

    class DerivedArray : BaseArray
    {
        public DerivedArray(int n) : base(n) { }
        //Поиск на наличие нечетных. Возвращает первую позицию нечетного элемента
        public bool FindOdd(out int pos)
        {
            bool isFound = false;
            pos = Length;
            for (int i = 0; i < Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    pos = i;
                    isFound = true;
                    break;
                }
            }
            return isFound;
        }
        //Поиск позиции последнего четного
        public bool FindLastEven(out int pos)
        {
            bool isFound = false;
            pos = Length;
            for (int i = 0; i < Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    pos = i;
                    isFound = true;
                }
            }
            return isFound;
        }
        //Поиск позиции максимального нечетного элемента
        public int FindLastMaxOdd(int n)
        {
            if (!FindOdd(out int maxI)) throw new Exception("Ошибка! В массиве отсутсвуют нечетные элементы");
            int max = arr[maxI];

            for (int i = maxI; i < n; i++)
            {
                if (arr[i] % 2 == 1 && max <= arr[i])
                {
                    max = arr[i];
                    maxI = i;
                }
            }
            return maxI;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите длину массива");
                int size = Convert.ToInt32(Console.ReadLine());
                DerivedArray arr = new DerivedArray(size);
                //arr.FillRand(50);
                //Console.WriteLine("Введите элементы массива");
                //arr.Input();
                arr.Print();
                int posMax;
                if (arr.FindLastEven(out int n))
                {
                    posMax = arr.FindLastMaxOdd(n);
                    Console.WriteLine($"Четный элемент найден. Поиск до последнего четного(pos = {n}).");
                }
                else
                {
                    posMax = arr.FindLastMaxOdd(arr.Length);
                    Console.WriteLine("Четный элемент не найден. Поиск до конца массива.");
                }
                Console.WriteLine($"Позиция максимального нечетного элемента : {posMax}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
