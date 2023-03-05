using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int userNumber = int.Parse(Console.ReadLine());



            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Число четное");

            }
            else
            {
                Console.WriteLine("Число нечетное");

            }
        }
    }
}
