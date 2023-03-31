using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //    Задание 1.Случайная матрица
            //Что нужно сделать
            //Выведите на экран матрицу заданного размера и заполните её случайными числами.Детальный алгоритм работы приложения:

            //Сначала пользователю предлагается ввести количество строк в будущей матрице.
            //Затем — ввести количество столбцов в будущей матрице.
            //Когда данные будут получены, нужно создать в памяти матрицу заданного размера.
            //Используя Random, заполнить матрицу случайными целыми числами.
            //Вывести полученную матрицу на экран.
            //Вывести сумму всех элементов этой матрицы на экран отдельной строкой.
            // Рекомендация
            //Для работы с матрицами используйте вложенные циклы.

            //Что оценивается
            //Программа выводит на экран случайно созданную матрицу предварительно заданного размера, а также сумму всех элементов в ней.

            Console.WriteLine("Введите количество строк ");
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[lines, columns];
           
            Random r = new Random();

            int sum = 0;

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                int localsum = 0;
                for(int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = r.Next(0, 10);     //Диапазон случайно загаданных чисел
                    localsum += matrixA[i, j];
                    Console.Write($"{matrixA[i,j], 2}");
                }
                Console.WriteLine($" : {localsum}");
                
            }
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += matrixA[i, j];
                }
                
            }
            Console.WriteLine($" Сумма всех элементов этой матрицы : {sum}");

            Console.ReadKey();

            #endregion
            
        }
    }
}
