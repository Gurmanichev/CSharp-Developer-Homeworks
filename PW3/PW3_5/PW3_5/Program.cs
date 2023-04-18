using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное целое число  \n ");
            int minUserValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное целое число  \n ");
            int maxUserValue = int.Parse(Console.ReadLine());

            Random secretValue = new Random();

            int x = secretValue.Next(minUserValue, maxUserValue);

            Console.WriteLine("Введите загаданное число ");

            string userNumberString;
            while (true)
            {
                userNumberString = Console.ReadLine();

                if (userNumberString == string.Empty)
                {
                    Console.WriteLine("Загаданное число " + x);
                    break;
                }
                
                int userNumber = int.Parse(userNumberString);

                if (userNumber == x)
                {
                    Console.WriteLine("Вы угадали " + userNumber);
                    break;
                }
                if (userNumber < x)
                {
                    Console.WriteLine("Загаданное больше чем введеное ");
                    
                }
                if (userNumber > x)
                {
                    Console.WriteLine("Загаданное меньше чем введеное ");
                    
                }

            }

            Console.ReadKey();

        }
    }
}
