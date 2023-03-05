using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool simple = true;
            Console.Write("Введите простое число: ");
            int userNumber = int.Parse(Console.ReadLine());
            int A = 2;

            if (simple)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }

            while (A <= userNumber - 1)
            {
                if (userNumber % A == 0)
                {
                    simple = false;
                    break;
                }
                A++;
            }

            Console.ReadKey();

        }
            
    }
}