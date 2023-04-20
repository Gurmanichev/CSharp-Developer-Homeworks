using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PW5
{
    internal class Program
    {

        static string[] SplitText(string userText)
        {
            return userText.Split(' ');
        }

       

        static string Reverse(string userText)
        {
            string [] splitting = SplitText(userText);
            string reversedPhrase = " ";
            for (int i = splitting.Length  - 1; i >= 0; i--)
            {
                reversedPhrase += splitting[i] + " ";
            }
            return reversedPhrase;
           
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение ");
            string userText = Console.ReadLine();
            string reversedPhrase = Reverse(userText);

            Console.WriteLine( reversedPhrase );
        }
    }
}
