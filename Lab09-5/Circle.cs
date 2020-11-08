using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5
{
    class Circle:Shape
    {
        public Circle(double d)
        {
          this.Pr4 = d;
        }

        public void Initialisation()
        {
            //Console.WriteLine("Введите диаметр окружности:");
            //Sh1.Pr4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Радиус окружности равен: {0}", Pr4/2);
        }
        public void Calc()
        {
            Pr5 = 2 * Math.PI * Pr4/2;
            Console.WriteLine("Периметр окружности равен:{0: 0.00}", Pr5);
            Pr6 = Math.PI * Math.Pow(Pr4, 2) / 4;
            Console.WriteLine("Площадь окружности:{0: 0.00}", Pr6);
            Console.WriteLine("================================");
        }

    }
}
