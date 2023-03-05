using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2_Ex._1
{
    internal class Program
    {
        static void Main()
        {
            string fullName = "Плевалов Андрей Гаврилович";
            int age = 21;
            string eMail = "Gavrilyich2001@mail.ru";
            double programmingPoints = 82.2;
            double mathPoints = 73.9;
            double physicsPoints = 68.5;
            double totalPoints = programmingPoints + mathPoints + physicsPoints;
            double averagePoints = totalPoints / 3;
            string formated = averagePoints.ToString("#.##");
            


            string firstPattern = ("Ф.И.О.: {0} \nВозраст: {1} \nEMail: {2} \nБаллы по Програмированию: {3} \nБаллы по Математике: {4} \nБаллы по физике: {5} \nСумма всех баллов: {6} \nСредний балл: {7} ");

            Console.WriteLine(firstPattern, 
                              fullName, 
                              age, 
                              eMail, 
                              programmingPoints, 
                              mathPoints,
                              physicsPoints,
                              totalPoints,
                              formated);

        }
    }
}
