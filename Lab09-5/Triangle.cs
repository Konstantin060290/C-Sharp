using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5
{
    class Triangle: Shape,IRotate
    {
        public Triangle(double a, double b, double c)
        {
            this.Pr1 = a;
            this.Pr2 = b;
            this.Pr3 = c;
        }
       
        public void Initialisation()
        {
            
            //Console.WriteLine("Введите 3 стороны треугольника:");
            //Sh1.Pr1 = double.Parse(Console.ReadLine());
            //Sh1.Pr2 = double.Parse(Console.ReadLine());
            //Sh1.Pr3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Стороны треугольника a={0: 0.00}, b={1: 0.00}, c={2: 0.00}", Pr1, Pr2, Pr3);

        }

        public void Calc()
        {
            Pr5 = Pr1 + Pr2 + Pr3;
            Console.WriteLine("Периметр треугольника равен:{0: 0.00}", Pr5);
            double p1;
            p1 = (Pr1 + Pr2 + Pr3) / 2;
            Pr6 = Math.Sqrt(p1 * (p1 - Pr1) * (p1 - Pr2) * (p1 - Pr3));
            Console.WriteLine("Площадь треугольника:{0: 0.00}", Pr6);
            
        }

        public void Check()
        {
            if ((Pr1 + Pr2) > Pr3 && (Pr1 + Pr3) > Pr2 && (Pr2 + Pr3) > Pr1)
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
