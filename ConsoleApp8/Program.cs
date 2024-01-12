using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            void f (double xx, out double X)
            {
                X = 1;
                for(int i = 1; i <= xx; i++)
                {
                    X *= i;
                }
            }

            void st (double A, double k, out double s)
            {
                s = 1;
                for (int i = 1; i <= k; i++)
                {
                    s *= A;
                }
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

            f(x, out double n1);
            st(a, n, out double n2);
            st(c, m, out double n3);

            double F = n1 + n2 + y / a * n3;
            Console.WriteLine($"F = {F}");
        }
    }
}
