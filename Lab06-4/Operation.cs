using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4
{
    class Operation 
    {

        Triangle Tr1 = new Triangle();
        public void Initialisation()
        {
            
            Tr1.Prop1 = double.Parse(Console.ReadLine());
            Tr1.Prop2 = double.Parse(Console.ReadLine());
            Tr1.Prop3 = double.Parse(Console.ReadLine());
        }

        public void Perimeter()
        {
            
            double p = Tr1.Prop1 + Tr1.Prop2 + Tr1.Prop3;
            Console.WriteLine(p);
            
        }

        public void Area()
        {
            
            double p1;
            p1 = (Tr1.Prop1 + Tr1.Prop2 + Tr1.Prop3) / 2;
            double s;
            s = Math.Sqrt(p1 * (p1 - Tr1.Prop1) * (p1 - Tr1.Prop2) * (p1 - Tr1.Prop3));
            Console.WriteLine(s);
        }

        public void Screen()
        {


            Console.WriteLine("Стороны треугольника a={0}, b={1}, c={2}", Tr1.Prop1, Tr1.Prop2, Tr1.Prop3);
        }

        public void Check()
        {

            if ((Tr1.Prop1 + Tr1.Prop2) > Tr1.Prop3 && (Tr1.Prop1 + Tr1.Prop3) > Tr1.Prop2 && (Tr1.Prop2 + Tr1.Prop3) > Tr1.Prop1)
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
