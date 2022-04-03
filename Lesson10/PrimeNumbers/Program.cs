using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int endNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers within the range of {0} and {1} are ", startNum, endNum);
            Primenumbers(startNum, endNum);
          
            Console.ReadKey();
        }

        static int Primenumbers(int startNum, int endNum)
        {
            int num = startNum;

            if (num > endNum )
            {
                Console.WriteLine("");
                Console.WriteLine("no more prime numbers within the specified range");
               // return 0;
            }
            else if (num == 2 || num == 3 || num == 5)
            {
                Console.Write(num + ", ");
                Primenumbers(startNum + 1, endNum);
                
            }
            else if(num % num == 0 && num % 1 ==0 && num % 2 !=0 && num % 3 != 0 && num % 5 != 0 && num !=1)
            {
                Console.Write(num + ", ");
                Primenumbers(startNum + 1, endNum);
                
            }
            else
            {
                Primenumbers(startNum + 1, endNum);
            }
            return 0;
        }
    }
}
