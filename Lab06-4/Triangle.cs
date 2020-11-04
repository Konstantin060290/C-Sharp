using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4
{
    class Triangle 
    {
        private double a;
        public double Prop1
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }
        private double b;
        public double Prop2
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        private double c;

        public double Prop3
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }
        
        
        public void Initialisation()
        {
            
            Prop1 = double.Parse(Console.ReadLine());
            Prop2 = double.Parse(Console.ReadLine());
            Prop3 = double.Parse(Console.ReadLine());
        }

        public void Perimeter()
        {
            
            double p = Prop1 + Prop2 + Prop3;
            Console.WriteLine(p);
            
        }

        public void Area()
        {
            
            double p1;
            p1 = (Prop1 + Prop2 + Prop3) / 2;
            double s;
            s = Math.Sqrt(p1 * (p1 - Prop1) * (p1 - Prop2) * (p1 - Prop3));
            Console.WriteLine(s);
        }

        public void Screen()
        {


            Console.WriteLine("Стороны треугольника a={0}, b={1}, c={2}", Prop1, Prop2, Prop3);
        }

        public void Check()
        {

            if ((Prop1 + Prop2) >Prop3 && (Prop1 +Prop3) > Prop2 && (Prop2 + Prop3) > Prop1)
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
