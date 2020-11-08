using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 стороны треугольника:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            Triangle Op1 = new Triangle(a,b,c);
            Op1.Check();
            Op1.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Op1.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Op1.Area();
            Console.WriteLine("=============================");

            Triangle Op2 = new Triangle(a);
            Op2.Check();
            Op2.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Op2.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Op2.Area();


           
          
        }
    }
}
