using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5
{
   
        
    class Square:Shape,IRotate
    {

        public Square(double a)
        {
            this.Pr1 = a;
        }
        
        public void Initialisation()
        {
            //Console.WriteLine("Введите сторону квадрата:");
            //Sh1.Pr1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Cторона квадрата равна: {0}", Pr1);
        }
        public void Calc()
        {
            Pr5 = 4 * Pr1;
            Console.WriteLine("Периметр квадрата равен:{0: 0.00}", Pr5);
            Pr6 =Math.Pow(Pr1, 2);
            Console.WriteLine("Площадь квадрата:{0: 0.00}", Math.Round(Pr6,2));
            
        }

        public void Message(object o)
        {
            Console.WriteLine("Квадрат вращается вокург своего центра!");
            Console.WriteLine("================================");
        }

    }
}
