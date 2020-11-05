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
            Triangle Op2 = new Triangle("Со вводом");
            Console.WriteLine("Введите сторону треугольника:");
            Op2.Initialisation("Равносторонний");
            Op2.Check();
            Op2.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Op2.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Op2.Area();


            Triangle Op1 = new Triangle();
            //Console.WriteLine("Введите 3 стороны треугольника:");
            //Op1.Initialisation();
            Op1.Check();
            Op1.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Op1.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Op1.Area();
            
          
        }
    }
}
