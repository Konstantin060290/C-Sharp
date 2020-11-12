using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Zachet
{
    interface IEmployee
    {
        bool Vacation();
    }
    class Person
    {
        public string Surname { get; set; }
        public int DBirth { get; set; }
        public int MBirth { get; set; }
        public int YBirth { get; set; }

        public string Faculty { get; set; }

        public string Position { get; set; }
        public int Exp { get; set; }

        public void CalcAge()
        {
            int day;
            int month;
            int age;
            day = DateTime.Now.Day - DBirth;
            month = DateTime.Now.Month - MBirth;
            if (month < 0)
            {
                age = DateTime.Now.Year - YBirth - 1;
                Console.WriteLine("Возраст ={0} лет", age);
            }
            else if (month == 0 & day < 0)
            {
                age = DateTime.Now.Year - YBirth - 1;
                Console.WriteLine("Возраст ={0} лет", age);

            }
            else
            {
                age = DateTime.Now.Year - YBirth;
                Console.WriteLine("Возраст ={0} лет", age);
            }
        }
        

        public void CalcSalary()
        {
            int salary;
                      

            if (Exp >= 0 && Exp < 5)
            { salary = 10; 
            Console.WriteLine("Зарплата = {0}",salary);
            }
            else if (Exp >= 5 && Exp < 10)
            { salary = 15;
            Console.WriteLine("Зарплата = {0}", salary);
            }
            else
            { salary = 20;
            Console.WriteLine("Зарплата = {0}", salary);
            }

        }
    }
}
