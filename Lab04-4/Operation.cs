using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_4_check
{

    public class Operation
    {

        static double p1;   //Периметр
        static double p;    //Полупериметр
        static double s;    //Площадь
        static double a;    //Сторона 1
        static double b;    //Сторона 2
        static double c;    //Сторона 3
        static bool exist;

        public static double Area()
        {
            
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());
            Operation.Check();
            p1 =a+b+c; //периметр
            p = p1 / 2; //Полупериметр
            s = Math.Sqrt(p *(p-a)*(p-b)*(p-c));   //Площадь
            return s;
        }

        public static double Area(double s2)
        {
            
            a = Double.Parse(Console.ReadLine());
            Operation.Check(1);
            p1 = a*3; //периметр
            p = p1 / 2; //Полупериметр
            s2 = Math.Sqrt(p * (p - a) * (p - a) * (p - a));   //Площадь
            return s2;
        }


        private static bool Check()
        {

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                Console.WriteLine("Треугольник существует");
                return exist = true;
            }
           
            else
            {
                Console.WriteLine("Треугольник не существует");
                Environment.Exit(0);
                return exist = false;
                            
            }
        }
        private static bool Check(int aa)
        {

            if (a>0)
            {
                Console.WriteLine("Треугольник существует");
                return exist = true;
            }
         
            else
            {
                Console.WriteLine("Треугольник не существует");
                Environment.Exit(0);
                return exist = false;
                
            }
        }

    }
}
   


