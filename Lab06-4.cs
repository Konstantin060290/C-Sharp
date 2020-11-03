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
            
            Console.WriteLine("Введите 3 стороны треугольника:");
            Operation.Initialisation();
            Operation.Check();
            Operation.Screen();
            Console.WriteLine("Периметр треугольника равен:");
            Operation.Perimeter();
            Console.WriteLine("Площадь треугольника равна:");
            Operation.Area();

        }
    }
}


  

