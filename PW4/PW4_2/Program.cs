using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2.Сложение матриц
            //Что нужно сделать
            //Используя размеры матрицы из предыдущего задания, создайте ещё одну матрицу.Сложите две матрицы.

            //Что оценивается
            //Программа выводит на экран две случайные матрицы и их сумму.

            Console.WriteLine("Введите количество строк ");
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[lines, columns];

            Random r = new Random();

            Console.WriteLine("Элементы матрицы А ");

            for (int i = 0; i < lines; i++)
            {
                
                for (int j = 0; j < columns; j++)
                {
                    matrixA[i, j] = r.Next(0, 10);     //Диапазон случайно загаданных чисел
                    
                    Console.Write($"{matrixA[i,j]} ");
                }
                Console.WriteLine();
            }
           Console.WriteLine("Элементы матрицы В ") ;

            int[,] matrixB = new int[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                for(int j = 0; j < columns;j++)
                {
                    matrixB [i,j] = r.Next(0, 10);
                    Console.Write($"{matrixB[i,j]} ");
                }
               Console.WriteLine();
            }
            Console.WriteLine("Элементы матрицы С ");

            int[,] matrixC = new int[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write($"{matrixC[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
        
    }
}
