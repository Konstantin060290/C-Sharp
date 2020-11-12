using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Teacher:Person,IEmployee
    {
        
        public bool Vac { get; set; }
        public int DWork { get; set; }
        public int MWork { get; set; }
        public int YWork { get; set; }
        
       
            public Teacher(string a, int b, int c, int d, string e, string f, bool h, int j, int k, int m)
                {
            Surname = a; DBirth = b;
            MBirth = c; YBirth = d;
            Faculty = e; Position = f;
            Vac = h;
            DWork = j; MWork = k;
            YWork = m;
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
        public bool Vacation()
        {
            Console.WriteLine("Сотрудник находится в отпуске!");
            return true;
        }
        public int CalcExp()
        {
            int day;
            int month;
            day = DateTime.Now.Day - DWork;
            month = DateTime.Now.Month - MWork;
            if (month < 0)
            {
                Exp = DateTime.Now.Year - YWork - 1;
                Console.WriteLine("Стаж ={0} лет", Exp);
            }
            else if (month == 0 & day < 0)
            {
                Exp = DateTime.Now.Year - YWork - 1;
                Console.WriteLine("Стаж ={0} лет", Exp);

            }
            else
            {
                Exp = DateTime.Now.Year - YWork;
                Console.WriteLine("Стаж ={0} лет", Exp);
            }

            return Exp;
        }


    }

    
}
