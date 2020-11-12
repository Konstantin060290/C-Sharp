using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Manager:Person
    {
        public Manager(string a, int b, int c, int d, string e, string f)
        {
            Surname = a; DBirth = b;
            MBirth = c; YBirth = d;
            Faculty = e; Position = f;
        }
        public void Display()
        { 
            Console.WriteLine("Фамилия-{0}, Дата рождения-{1}/{2}/{3}", Surname, DBirth, MBirth, YBirth);
            Console.WriteLine("Факультет-{0}, Должность-{1}", Faculty, Position);

        }

        public void Separate()
        {
            Console.WriteLine("===============================================================================");
        }

    }
}


