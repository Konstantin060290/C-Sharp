using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_4
{
    class Target_game
    {

        static void Main(string[] args)
        {

            double[] radius_vectors = new double[4] { 10, 100, 200, 300 };
            Console.WriteLine("Зона мишени X...200 - 10 баллов;");
            Console.WriteLine("Зона мишени 200...400 - 5 баллов;");
            Console.WriteLine("Зона мишени 400...600 - 1 балл;");
            Console.WriteLine("Центр мишени оценивается как - 20 баллов;");
            int n = 5; //Количество выстрелов
            int score = 0;
            int i = 0;
            while (i < n)
            {
                i++;
                Console.WriteLine("Введите данные о выстреле по мишени в виде пары чисел x и y:");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                Console.WriteLine("Z={0}", z);

                if (z <= radius_vectors[0])
                    score += 20;
                else if (z > radius_vectors[0]* 2 & z <= radius_vectors[1] * 2 )
                    score += 10;
                else if (z > radius_vectors[1] * 2 & z <= radius_vectors[2] * 2)
                    score += 5;
                else if (z > radius_vectors[2] * 2 & z <= radius_vectors[3] * 2)
                    score += 1;
               
                else score += 0;

                Console.WriteLine("Количество очков={0}", score);


            }
        }

    }
}
