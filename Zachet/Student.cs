using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Student:Person
    {
        public string Group { get; set; }
        
        public Student(string a, int b, int c, int d, string e, string f)
        {
            Surname = a; DBirth = b;
            MBirth = c; YBirth = d;
            Faculty = e; Group = f;
           
        }    
            public void Display()
        {
            Console.WriteLine("Фамилия-{0}, Дата рождения-{1}/{2}/{3}", Surname, DBirth, MBirth, YBirth);
            Console.WriteLine("Факультет-{0}, Группа-{1}", Faculty, Group);
           
        }
        public void Separate()
        {
            Console.WriteLine("===============================================================================");
        }
    }
}
