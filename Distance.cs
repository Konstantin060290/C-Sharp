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
        public double distance;
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
                Distance D;
                Console.WriteLine("Введите длину в футах и дюймах");
                D.feet = double.Parse(Console.ReadLine());
                D.inch = double.Parse(Console.ReadLine());
                    if (D.inch < 12)
                        Console.WriteLine("Длина = {0}'-{1}'' ", D.feet, D.inch);
                    else
                    {
                        int NFeet = Convert.ToInt16(D.inch / 12);
                        int FFeet = Convert.ToInt16(D.feet) + NFeet;
                        double Finch = D.inch - (NFeet * 12);
                        Console.WriteLine("Длина = {0}'-{1}''", FFeet, Finch);
                        Console.ReadLine();
                    
                    }
                    
                    }
                
            }
        }
    }
}
