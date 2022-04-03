using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any string value: ");
            string str = Console.ReadLine();

            StringLength(str);
            Console.ReadKey();
        }

        static void StringLength(string str)
        {
            int result;
            result = str.Length;
            Console.WriteLine("The total number of string Character is "+ result);
        }

    }
}
