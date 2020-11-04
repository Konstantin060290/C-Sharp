using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_4_check
{
    class Program
    {
        
        static void Main()
        {
            Operation Op1 = new Operation();

            Console.WriteLine("Искомый треугольник равносторонний? Y/N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Будет выполнен расчет площади равностороннего треугольника");
                    Console.WriteLine("Введите длину стороны треугольника:");
                    Console.WriteLine("Площадь треугольника равна:{0}",Operation.Area(0.1));
                    break;
                case "N":
                    Console.WriteLine("Будет выполнен расчет площади неравностороннего треугольника");
                    Console.WriteLine("Введите длины сторон треугольника:");
                    Console.WriteLine("Площадь треугольника равна:{0}", Operation.Area());
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву/цифру");
                    break;
            }
        }
    }
}
