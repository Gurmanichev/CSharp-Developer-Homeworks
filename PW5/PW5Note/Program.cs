using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW5Note
{
    internal class Program
    {
        static void Print(char[,] Map)
        {
            for (int i = 0;  i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    Console.Write(Map[i, j] == '.' ? ' ' : Map[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void ToColor(char[,] Map, int PosX, int PosY) 
        {
            if (Map[PosX, PosY] == '.')
            {
                Map[PosX, PosY] = '+';
                ToColor(Map, PosX - 1, PosY);
                ToColor(Map, PosX, PosY + 1);
                ToColor(Map, PosX + 1, PosY);
                ToColor(Map, PosX, PosY - 1);
            }
        }
        static void Main(string[] args)
        {
            char[,] map = new char[,]
            {
               {'.','.', '.', '.'},
               {'+','.','.', '.',}
            };
            Print(map);
            Console.WriteLine();
            ToColor(map, 1, 1);
            Print(map);
        }

    }
       
}

