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
            bool simple  = true;
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;

            while (i <= n - 1)
            {
                if (n % i == 0)
                {
                    simple = false;
                    break;
                }
                i++;
            }

            if (simple == true)
            {
                Console.WriteLine("Число простое");
            }
            if (simple == false)
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();
        }
    }
}
            
    
