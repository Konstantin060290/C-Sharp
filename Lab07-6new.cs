using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_6new
{
    public interface IComparable
    {
        int CompareTo(object o);
    }
    class Program
    {
        static void Main(string[] args)
        {

            Book B1 = new Book { Pr1 = "Н.В. Гоголь", Pr2 = "Мертвые души", Pr3 = 1835, Pr4 = 871 };
            Book B2 = new Book { Pr1 = "А.С. Пушкин", Pr2 = "Капитанская дочка", Pr3 = 1836, Pr4 = 401 };
            Book B3 = new Book { Pr1 = "М.Ю. Лермонтов", Pr2 = "Герой нашего времени", Pr3 = 1840, Pr4 = 207 };
            Book[] books = new Book[] { B1, B2, B3 };
            Array.Sort(books);

            foreach (Book bb in books)
            {
                Book B10 = new Book();
                B10.Display(bb);
            }

        }
    }
}
class Book : IComparable
{
    private string author;
    public string Pr1
    {
        get
        {
            return author;
        }

        set
        {
            author = value;
        }
    }
    private string title;
    public string Pr2
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }
    private int year;
    public int Pr3
    {
        get
        {
            return year;
        }

        set
        {
            year = value;
        }
    }
    private int pages;
    public int Pr4
    {
        get
        {
            return pages;
        }

        set
        {
            pages = value;
        }
    }

    public int CompareTo(object o)
    {
        
        Book it = (Book)o;
        if (this.Pr3 == it.Pr3) return 0;
        else if (this.Pr3 > it.Pr3) return 1;
        else return -1;
    }
    public void Display(Book kniga)
    {

        Console.WriteLine(kniga.Pr1);
        Console.WriteLine(kniga.Pr2);
        Console.WriteLine(kniga.Pr3);
        Console.WriteLine(kniga.Pr4);
        Console.WriteLine("===========");
    }

}
