using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5
{
    class Triangle:IRotate
    {

        Shape Sh1 = new Shape(5,6,7);
        public void Initialisation()
        {

            //Console.WriteLine("Введите 3 стороны треугольника:");
            //Sh1.Pr1 = double.Parse(Console.ReadLine());
            //Sh1.Pr2 = double.Parse(Console.ReadLine());
            //Sh1.Pr3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Стороны треугольника a={0: 0.00}, b={1: 0.00}, c={2: 0.00}", Sh1.Pr1, Sh1.Pr2, Sh1.Pr3);

        }

        public void Calc()
        {
            Sh1.Pr5 = Sh1.Pr1 + Sh1.Pr2 + Sh1.Pr3;
            Console.WriteLine("Периметр треугольника равен:{0: 0.00}", Sh1.Pr5);
            double p1;
            p1 = (Sh1.Pr1 + Sh1.Pr2 + Sh1.Pr3) / 2;
            Sh1.Pr6 = Math.Sqrt(p1 * (p1 - Sh1.Pr1) * (p1 - Sh1.Pr2) * (p1 - Sh1.Pr3));
            Console.WriteLine("Площадь треугольника:{0: 0.00}", Sh1.Pr6);
            
        }

        public void Check()
        {
            if ((Sh1.Pr1 + Sh1.Pr2) > Sh1.Pr3 && (Sh1.Pr1 + Sh1.Pr3) > Sh1.Pr2 && (Sh1.Pr2 + Sh1.Pr3) > Sh1.Pr1)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
                System.Environment.Exit(1);
            }
        }

        public void Message(object o)
        {

            
            Console.WriteLine("Треугольник вращается вокург своего центра!");
            Console.WriteLine("================================");
        }

    }
}
