using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_3
{
    public struct Distance
    {
        public double feet;
        public double inch;
        
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
                    Distance D1;
                    Console.WriteLine("Введите длину первого отрезка в футах и дюймах:");
                    D1.feet = double.Parse(Console.ReadLine());
                    D1.inch = double.Parse(Console.ReadLine());
                    Distance D2;
                    Console.WriteLine("Введите длину второго отрезка в футах и дюймах:");
                    D2.feet = double.Parse(Console.ReadLine());
                    D2.inch = double.Parse(Console.ReadLine());
                    Distance D3;
                    D3.feet = D1.feet + D2.feet;
                    D3.inch = D1.inch + D2.inch;
                                      
                    if (D3.inch < 12)
                        Console.WriteLine("Суммарная длина = {0}'-{1}'' ", D3.feet, D3.inch);
                    else
                    {
                        int NFeet = Convert.ToInt16(D3.inch / 12);//Выделяю целое число футов
                        int FFeet = Convert.ToInt16(D3.feet) + NFeet;//Полное число футов
                        double Finch = D3.inch - (NFeet * 12);//Остаток дюймов
                        Console.WriteLine("Длина = {0}'-{1}''", FFeet, Finch);
                        Console.ReadLine();

                    }

                }

            }
        }
    }
}
