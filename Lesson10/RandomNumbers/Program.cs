using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start value to generate random number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end value to generate random number: ");
            int end = int.Parse(Console.ReadLine());

            RandomNumbers(start, end);
            Console.ReadKey();
        }
         static int RandomNumbers(int start, int end)
        {
            Stopwatch timer = new Stopwatch();
            Random rnd = new Random();
            int iter = 0;

            List<int> randomNumbers = new List<int>();
            Console.WriteLine("");
            Console.WriteLine("The random numbers for the specified range are");
            
            timer.Start();
            int num = rnd.Next(start, end);

            while (!randomNumbers.Contains(num))
            {
                Console.WriteLine(num);
                randomNumbers.Add(num);
                rnd.Next(start, end);
                num = rnd.Next(start, end);
                iter++;
            }

            timer.Stop();
            Console.WriteLine("The number of iteration is: "+ iter);
            Console.WriteLine("The elasped time is {0} ms", timer.ElapsedMilliseconds);
            return iter;
        }
    }
}
