using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Teacher T1 = new Teacher ("Иванов", 06, 02, 1970, "Информационных технологий", "Ст.преподаватель", true, 07, 03, 2000);
            Teacher T2 = new Teacher("Петров", 05, 01, 1990, "Информационных технологий", "Ассистент", false, 10, 10, 2020);
            Teacher T3 = new Teacher("Сидоров", 11, 11, 1984, "Дизайна", "Преподаватель", true, 31, 06, 2018);
            Teacher[] teachers = new Teacher[] { T1, T2, T3 };
            foreach (Teacher i in teachers)
            {

                if (i.Vac == true)
                {
                    i.Display();
                    i.CalcAge();
                    i.Vacation();
                    i.CalcExp();
                    i.CalcSalary();
                    i.Separate();
                }
                else
                { 
                    i.Display();
                    i.CalcAge();
                    i.CalcExp();
                    i.CalcSalary();
                    i.Separate();
                }
            }
            
            Student S1 = new Student("Третьяков", 22, 09, 2001, "Энергомашиностроительный", "4032");
            Student S2 = new Student("Денисов", 22, 09, 2002, "Инженерно-строительный", "7045");
            Student S3 = new Student("Николаев", 22, 09, 2000, "Технической кибернетики", "8021");
            Student[] students = new Student[] { S1, S2, S3 };
            foreach (Student i in students)
            {
                i.Display();
                i.CalcAge();
                i.Separate();

            }

            Manager M1 = new Manager("Севастьянов", 17, 07, 1972, "Энергомашиностроительный", "Менеджер по работе с заказчиками");
            Manager[] managers = new Manager[] { M1};
            foreach (Manager i in managers)
            {
                i.Display();
                i.CalcAge();
                i.Separate();
            }

            Admin A1 = new Admin ("Аверьянова", 17, 07, 1987, "172-12");
            Admin[] admins = new Admin[] { A1 };
            foreach (Admin i in admins)
            {
                i.Display();
                i.CalcAge();
                i.Separate();
            }
        }
    }
}
