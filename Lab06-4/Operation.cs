using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4
{
    class Operation
    {
       
        static public void Initialisation()
        {
            Triangle Tr1 = new Triangle();
            Tr1.a = double.Parse(Console.ReadLine());
            Tr1.b = double.Parse(Console.ReadLine());
            Tr1.c = double.Parse(Console.ReadLine());
        }

        static public void Perimeter()
        {
            Triangle Tr1 = new Triangle();
            double p = Tr1.a + Tr1.b + Tr1.c;
            Console.WriteLine(p);
            
        }

        static public void Area()
        {
            Triangle Tr1 = new Triangle();
            double p1;
            p1 = (Tr1.a + Tr1.b + Tr1.c) / 2;
            double s;
            s = Math.Sqrt(p1 * (p1 - Tr1.a) * (p1 - Tr1.b) * (p1 - Tr1.c));
            Console.WriteLine(s);
        }

        static public void Screen()
        {


            Triangle Tr1 = new Triangle();
            Console.WriteLine("Стороны треугольника a={0}, b={1}, c={2}", Tr1.a, Tr1.b, Tr1.c);
        }

        static public void Check()
        {
            Triangle Tr1 = new Triangle();

            if ((Tr1.a + Tr1.b) > Tr1.c && (Tr1.a + Tr1.c) > Tr1.b && (Tr1.b + Tr1.c) > Tr1.a)
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
