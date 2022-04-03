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
            string str = Console.ReadLine().ToUpper();

            Console.WriteLine("The length of the string is: "+ StringCharacters(str));
            Console.ReadKey();
        }
        static string StringCharacters(string str)
        {
            int count = 0;
            char[] characters = str.ToCharArray();

            Console.WriteLine("The entered string value in uppercase is");

            for (int i = 0; i < characters.Length; i++)
            {
                char letter = characters[i];
                Console.WriteLine(letter);
                count++;
            }
            return count.ToString();
        }
        // i could not find the bottom of recursion for this problem, so i used for loop to solve it
    }
}
