using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            double c = double.Parse(Console.ReadLine());

            QuadraticFunction(a, b, c);

            Console.ReadKey();

        }
        static void QuadraticFunction(double a, double b, double c)
        {
            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}
