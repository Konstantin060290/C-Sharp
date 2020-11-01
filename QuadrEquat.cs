using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_5_check
{
    class QuadrEquat
    {
        static int Calc(ref double x1, ref double x2, ref double d, ref double a, ref double b, ref double c)
        {
            Console.WriteLine("Введите коэффициенты квадратного уравнения a, b, c");

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Уравнение не является квадратным");
                Environment.Exit(0);
            }
            d = Math.Pow(b, 2) - (4 * a * c);
            
            Console.WriteLine("Дискриминант = {0}", d);
            if (d < 0)
            {
                //Console.WriteLine("Корней уравнения с коэффциентами a={0}, b={1}, c={2} нет.", a, b, c);
                return -1;
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                                
                //Console.WriteLine("Корень уравнения с коэффциентами a ={0}, b ={1}, c ={2} один:x1 = x2 ={3}", a, b, c, x1);
                return 0;
            }
            else
            {
                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                //Console.WriteLine("Корни уравнения с коэффциентами a ={0}, b ={1}, c ={2} равны: x1 = {3}, x2={4}", a, b, c, x1, x2);
                return 1;
            }
        }
        static void Main(string[] args)
        {
            double x1r=0;
            double x2r=0;
            double ar = 0;
            double br = 0;
            double cr = 0;
            double dr = 0;

            Calc(ref x1r, ref x2r, ref dr, ref ar, ref br, ref cr);
            if (dr<0)
                Console.WriteLine("Корней уравнения с коэффциентами a={0}, b={1}, c={2} нет.", ar, br, cr);
            else if (dr==0)
                Console.WriteLine("Корень уравнения с коэффциентами a ={0}, b ={1}, c ={2} один:x1 = x2 ={3}", ar, br, cr, x1r);
            else
                Console.WriteLine("Корни уравнения с коэффциентами a ={0}, b ={1}, c ={2} равны: x1 = {3}, x2={4}", ar, br, cr, x1r, x2r);
            Console.ReadKey();


        }

        
    }
}
