using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_6
{
  

    class Program
    {
        
        
        static void Main(string[] args)
        {

           
            Book[] B1 = new Book[3];
            for (int i = 0; i < 3; i++)
                B1[i] = new Book();

            B1[0].Pr1 = "Н.В.Гоголь";
            B1[0].Pr2 = "Мертвые души";
            B1[0].Pr3 = 1835;
            B1[0].Pr4 = 871;
            B1[1].Pr1 = "А.С.Пушкин";
            B1[1].Pr2 = "Капитанска дочка";
            B1[1].Pr3 = 1836;
            B1[1].Pr4 = 401;
            B1[2].Pr1 = "М.Ю.Лермонтов";
            B1[2].Pr2 = "Герой нашего времени";
            B1[2].Pr3 = 1840;
            B1[2].Pr4 = 207;
           
            Book B2 = new Book();
            B2.Show();


        }
    }

}
