using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_6
{
    public interface IComparable
    {
        int CompareTo(object obj);

    }

    
    class Book: IComparable
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

        int IComparable.CompareTo(object obj)
        {

            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;

        }
        public void SetBook(String author, String title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }
        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n", author, title, year, pages);
        }
      
      
    }
}
