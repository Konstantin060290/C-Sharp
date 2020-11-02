using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4
{
    class Triangle
    {

        static double a;
        static double b;
        static double c;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 стороны треугольника:");
            Initialisation();
            Check();
            Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Area();
        }

        static void Initialisation()
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
        }                   
    
        static void Perimeter()
        {
           double p = a + b + c;
            Console.WriteLine(p);
        }

        static void Area()
        {
            double p1;
            p1 = (a + b + c) / 2;
            double s;
            s = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
            Console.WriteLine(s);
        }

        static void Screen()
        {
            Console.WriteLine("Стороны треугольника a={0}, b={1}, c={2}", a,b,c);
        }

        static void Check()
        {if ((a+b)>c && (a+c)>b && (b+c)>a)
            {
                Console.WriteLine("Треугольник существует");

            }
        else
            {
                Console.WriteLine("Треугольник не существует");
                System.Environment.Exit(1);
            }
        }

    }
}
