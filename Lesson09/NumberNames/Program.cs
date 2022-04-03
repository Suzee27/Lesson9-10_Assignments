using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace NumberNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to convert to words: ");
            int number = int.Parse(Console.ReadLine());

            NumberNames(number);
            Console.ReadKey();
        }

        static void NumberNames(int number)
        {
            string numberInWords = number.ToWords();
            Console.WriteLine("{0} = {1}", number, numberInWords);
        }
    }
}
