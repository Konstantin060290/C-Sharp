using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Admin:Person
    {
        public string Laboratory { get; set; }
        public Admin (string a, int b, int c, int d, string e)
        {
            Surname = a; DBirth = b;
            MBirth = c; YBirth = d;
            Laboratory = e;

        }
        public void Display()
        {
            Console.WriteLine("Фамилия-{0}, Дата рождения-{1}/{2}/{3}, Лаборатория - {4}", Surname, DBirth, MBirth, YBirth, Laboratory);
        }

        public void Separate()
        {
            Console.WriteLine("===============================================================================");
        }
    }
}

