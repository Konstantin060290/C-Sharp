using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            object o = null;
            
            Triangle Tr1 = new Triangle();
            Tr1.Initialisation();
            Tr1.Check();
            Tr1.Calc();
            Tr1.Message(o);
            Circle Cr1 = new Circle();
            Cr1.Initialisation();
            Cr1.Calc();
            Square Sq1 = new Square();
            Sq1.Initialisation();
            Sq1.Calc();
            Sq1.Message(o);
        }



    }
}
