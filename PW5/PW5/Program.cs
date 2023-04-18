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

        static string[] SplitText (string userText)
        {
            return userText.Split(' ');
        }
        
        static void Result(string[] userText)
        {
            foreach (string word in userText)
            {
                Console.WriteLine(word);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение ");
            string userText = Console.ReadLine();
            string[] words = SplitText(userText);
            Result(words);
            

        }
    }
}
