using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_4
{
    class Triangle
    {
        private double a;
        //public double Prop1
        //{
        //    get
        //    {
        //        return a;
        //    }

        //    set
        //    {
        //        a = value;
        //    }
        //}
        private double b;
        //public double Prop2
        //{
        //    get
        //    {
        //        return b;
        //    }

        //    set
        //    {
        //        b = value;
        //    }
        //}

        private double c;

        //public double Prop3
        //{
        //    get
        //    {
        //        return c;
        //    }

        //    set
        //    {
        //        c = value;
        //    }
        //}
        public Triangle()
        {
            a = 8;
            b = 10;
            c = 7;
        }

        public Triangle(string eqtr)
        {
           
        }


        public void Initialisation(string eqtr2)
        {

            a = double.Parse(Console.ReadLine());
            b = a;
            c = a;
            //b = double.Parse(Console.ReadLine());
            //c = double.Parse(Console.ReadLine());
        }

        public void Perimeter()
        {

            double p = a + b + c;
            Console.WriteLine(p);

        }

        public void Area()
        {

            double p1;
            p1 = (a + b + c) / 2;
            double s;
            s = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
            Console.WriteLine(s);
        }

        public void Screen()
        {


            Console.WriteLine("Стороны треугольника a={0}, b={1}, c={2}", a, b, c);

        }

     
            public void Check()
        {

            if ((a + b) > c && (a + c) > b && (b + c) > a)
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
