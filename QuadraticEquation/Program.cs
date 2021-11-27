using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2, x;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.Write("x1 =");
                Console.WriteLine(x1);
                Console.Write("x2 =");
                Console.WriteLine(x2);
            }
            else
                if (D == 0)
            {
                x = -b / (2 * a);
                Console.Write("x = ");
                Console.WriteLine(x);
            }
            else
                Console.WriteLine("Коренів немає\n");
            Console.ReadKey();
        }
    }
}
