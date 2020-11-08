using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_3
{
    class Distance
    {
        public int Feet { get; set; }
        public double Inch { get; set;}

        public Distance()
        { }
        public Distance(int feet, double inch)
        {
            Feet=feet;
            Inch=inch;
        }

        public static Distance operator +(Distance D3, Distance D4)
        {
            Distance sum = new Distance();
            if ((D3.Inch + D4.Inch) < 12)
            {
              sum.Feet = D3.Feet + D4.Feet;
              sum.Inch = D3.Inch + D4.Inch;
            }

            else
            {
                sum.Feet = D3.Feet + D4.Feet + ((Convert.ToInt32(D3.Inch + D4.Inch)) / 12);
                sum.Inch = (D3.Inch + D4.Inch) - (((Convert.ToInt32(D3.Inch + D4.Inch)) / 12) * 12);
            }
            return sum;

                       
        }

        public static Distance operator -(Distance D3, Distance D4)
        {
            Distance sum = new Distance();
  
                sum.Feet = D3.Feet - D4.Feet + ((Convert.ToInt32(D3.Inch - D4.Inch)) / 12);
                sum.Inch = (D3.Inch - D4.Inch) - (((Convert.ToInt32(D3.Inch - D4.Inch)) / 12) * 12);
           
            return sum;

        }
        public static bool operator >(Distance D3, Distance D4)
        {
            Distance comp = new Distance();

            if (D3.Feet > D4.Feet)
                return true;
            else
                return false;

        }
        public static bool operator <(Distance D3, Distance D4)
        {
            Distance comp = new Distance();

            if (D3.Feet < D4.Feet)
                return true;
            else
                return false;
        }

      
        public void ToString(int a)
        {
            Console.WriteLine("Суммарная длина = {0}'-{1}'' ", Feet, Inch);

        }
        public void ToString()
        {
        Console.WriteLine("Разность первого и второго = {0}'-{1}'' ", Feet, Inch);

        }
       
    }
    class Program
    {

        static void Main(string[] args)
        {

            {
                int i = 0;
                while (true)
                {
                    i++;

                    Console.WriteLine("Введите длину первого отрезка в футах и дюймах:");
                    int feet1 = int.Parse(Console.ReadLine());
                    double inch1 = double.Parse(Console.ReadLine());
                    Distance D1 = new Distance(feet1,inch1);
                    
                    Console.WriteLine("Введите длину второго отрезка в футах и дюймах:");
                    int feet2 = int.Parse(Console.ReadLine());
                    double inch2 = double.Parse(Console.ReadLine());
                    Distance D2 = new Distance(feet2,inch2);

                    
                    Distance D3 = new Distance();
                    D3 = D1 + D2;
                    D3.ToString(i);
                    Distance D4 = new Distance();
                    D4 = D1 - D2;
                    D4.ToString();
                    if (D1 > D2)
                        Console.WriteLine("Первый отрезок больше второго");
                    else if
                       (D1 < D2)
                        Console.WriteLine("Первый отрезок меньше второго");
                    else
                        Console.WriteLine("Сравнение не реализовано!");
                }
          
            }
        }
    }
}