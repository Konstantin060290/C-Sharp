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
            Triangle Op1 = new Triangle(5.0, 6.0, 7.0);
            
            Op1.Check();
            Op1.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Op1.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Op1.Area();

            Console.WriteLine("Введите сторону треугольника:");
            Triangle Op2 = new Triangle(5.0);
            
            Op2.Check();
            Op2.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Op2.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Op2.Area();


           
          
        }
    }
}
