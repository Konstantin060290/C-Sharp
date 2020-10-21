using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            double p, p1, S, a;
            Console.WriteLine("Введите периметр треугольника P1");
            p1 = Convert.ToDouble(Console.ReadLine());
            p = p1 / 2; //Полупериметр
            a = p1 / 3; //Сторона треугольника
            S = Math.Sqrt(p * Math.Pow((p-a),3));   //Площадь
            Console.WriteLine("Сторона\t\tПлощадь");
            Console.WriteLine($"{a:.0000}​​" + "\t\t" + $"{S:.0000}​​");

        }
    }
}
