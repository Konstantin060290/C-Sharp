using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_3
{
    class Array
    {
        static void Main(string[] args)
        {
            double ar = 0;
            double br = 0;
            double cr = 0;
            double dr = 0;
            MyArray(ref ar, ref br, ref cr, ref dr);
            double[] numsr= new double[4];
            numsr[0] = ar;
            numsr[1] = br;
            numsr[2] = cr;
            numsr[3] = dr;
            
            SumArray(numsr);
            ArrayAver(numsr);
            SumMinPl(numsr);
        }

       public static void MyArray(ref double a, ref double b, ref double c, ref double d)
        {
            Console.WriteLine("Введите 4 числа, как минимум одно из которых будет отрицательным");
            Console.WriteLine("Введите 1-е число массива:");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-е число массива:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3-е число массива:");
            c = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 4-е число массива:");
            d = Double.Parse(Console.ReadLine()); 
               
            double[] nums = new double[4];
            nums[0] = a;
            nums[1] = b;
            nums[2] = c;
            nums[3] = d;
        }
      
        public static void SumArray(double[]nums)
        {
            double sum = 0;
            foreach (int value in nums)
            {
                sum += value;
            }
           Console.WriteLine("Сумма цифр массива равна:{0}", sum);

        }

        public static void ArrayAver(double[] nums)
        {
            double sum = 0;
            foreach (int value in nums)
            {
                sum += value;
            }

            Console.WriteLine("Среднее значение массива равно:{0}", sum/nums.Length);

        }
        public static void SumMinPl(double[] nums)
        {
           
                Console.WriteLine("Сумма отрицательных чисел равна: {0}", nums.Where(x => x < 0).Aggregate((x, y) => x + y));
                Console.WriteLine("Сумма положительных чисел равна: {0}", nums.Where(x => x > 0).Aggregate((x, y) => x + y));
           
            }
        }
}