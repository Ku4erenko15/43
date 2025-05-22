using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество книг: ");
            int n = int.Parse(Console.ReadLine());

            Book[] books = new Book[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nКнига {i + 1}:");

                Console.Write("Название: ");
                string title = Console.ReadLine();

                Console.Write("Ф.И.О. автора: ");
                string author = Console.ReadLine();

                Console.Write("Год издания: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Количество страниц: ");
                int pages = int.Parse(Console.ReadLine());

                books[i] = new Book(title, author, year, pages);
            }

            Console.WriteLine("\n--- Информация о всех книгах ---");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Книга {i + 1}:\n{books[i]}");
            }
            Console.ReadKey();
        }
    }
}
