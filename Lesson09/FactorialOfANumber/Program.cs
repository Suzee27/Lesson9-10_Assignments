using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number to find its factorial: ");
            int number = int.Parse(Console.ReadLine());

            Factorial(number);
            Console.ReadKey();
        }

        static void Factorial(int number)
        {
            int factorial = number;
            if (number > 0)
            {
                for (int i = 1; i < number; i++)
                {
                    factorial = factorial * (number - i);
                }
                Console.WriteLine("The factorial of the number = " + factorial);
            }
            else
            {
                Console.WriteLine("can't find factorial of a number less than or equal to 0");
            }
        }
    }
}
