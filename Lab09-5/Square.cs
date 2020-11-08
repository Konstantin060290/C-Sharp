using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5
{
   
        
    class Square:IRotate
    {
       


        Shape Sh1 = new Shape(5,0);
        public void Initialisation()
        {
            //Console.WriteLine("Введите сторону квадрата:");
            //Sh1.Pr1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Cторона квадрата равна: {0}", Sh1.Pr1);
        }
        public void Calc()
        {
            Sh1.Pr5 = 4 * Sh1.Pr1;
            Console.WriteLine("Периметр квадрата равен:{0: 0.00}", Sh1.Pr5);
            Sh1.Pr6 =Math.Pow(Sh1.Pr1, 2);
            Console.WriteLine("Площадь квадрата:{0: 0.00}", Math.Round(Sh1.Pr6,2));
            
        }

        public void Message(object o)
        {
            Console.WriteLine("Квадрат вращается вокург своего центра!");
            Console.WriteLine("================================");
        }

    }
}
