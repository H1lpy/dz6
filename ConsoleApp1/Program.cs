using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double f(double xx)
            {
                double X = 1;
                for (int i = 1; i <= xx; i++)
                {
                    X *= i;
                }
                return X;
            }

            double st(double A, double k)
            {
                double s = 1;
                for (int i = 1; i <= k; i++)
                {
                    s *= A;
                }
                return s;
            }

            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("n: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("m: ");
            double m = double.Parse(Console.ReadLine());

            double F = f(x) + st(a, n) + y / a * st(c, m);
            Console.WriteLine($"F = {F}");
        }
    }
}
