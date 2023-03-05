using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3._10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, укажите количество карт на руках");
            int userQuantityCard = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество карт на руках = " + userQuantityCard);
            int summ = 0;
            Console.WriteLine("Введите номинал карты от 6 до 10 и J; Q; K; T. ");
            int b = 0;
            for (int i = 0; i < userQuantityCard; i++)
            {
                b++;

                if (b > 1)
                {
                    Console.WriteLine("Введите " + b + "-й номинал карты: от 6 до 10 и J; Q; K; T. ");
                }
                
                
                string nominalNumber = (Console.ReadLine());
                
                switch (nominalNumber)
                {
                    case "6":summ += 6;break;
                    case "7": summ += 7;break;
                    case "8": summ += 8;break;
                    case "9": summ += 9;break;
                    case "10": summ += 10;break;
                    case "J":summ += 10; break;
                    case "Q": summ += 10; break;
                    case "K": summ += 10; break;
                    case "T": summ += 11; break;
                                                   
                }
                    Console.WriteLine($"Суммарный номирал карт = " + summ  + "\n"); 

                               
                
            }
            

            
        }
    }
}
