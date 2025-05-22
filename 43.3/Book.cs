using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43._3
{
    struct Book
    {
        public string Title;
        public string Author;
        public int Year;
        public int Pages;

        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"Название: {Title}\nАвтор: {Author}\nГод издания: {Year}\nСтраниц: {Pages}\n";
        }
    }
}
