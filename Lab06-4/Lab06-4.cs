using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Triangle Op1 = new Triangle();
            Console.WriteLine("Введите 3 стороны треугольника:");
            Op1.Initialisation();
            Op1.Check();
            Op1.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Op1.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Op1.Area();

        }
    }
}


  

