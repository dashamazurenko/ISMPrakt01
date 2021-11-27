using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("d = ");
            d = double.Parse(Console.ReadLine());

            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            double y = 5 * (a + b) * (c - d) / ((1.0 / 2.0) * c) + (d * d) * ((a * a) - (b * b)) / (b - a);
            double z = ((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / 5 * a + 3 * b;
            double r = ((1.0 / 2.0) * a + (3.0 / 4.0) * b - (7.0 / 5.0) / 3 * c + 1) + 1 / (a - c);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
