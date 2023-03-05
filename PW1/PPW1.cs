using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Againest                          //Создание собственной библиотеки
{
    
    internal class Program                  //Класс
    {
        
        static void Main(string[] args)     //Первичный код
        {
            
            WriteLine ("Hello World !!! ");  //Вывод текста в консоль линией

          

            Write ("Hello ");                //Вывод тескта в консоль по отдельности
            Write ("World "); 
            Write ("!!! ");

           while (ReadKey().Key != ConsoleKey.Enter) ;                     //Ожидание нажатия клавиши Enter от пользователя
        }
    } 
}
