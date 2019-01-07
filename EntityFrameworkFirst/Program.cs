using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BookContext db = new BookContext()) // чтобы посмотреть на БД из Студии View->SQL Server Object Explorer
            {
                Book book_1 = new Book { Name = "Farewell to Arms", Author = "Ernest Hemingway" };
                Book book_2 = new Book { Name = "Vanity Fair", Author = " William Makepeace Thackeray" };
                db.Books.Add(book_1);
                db.Books.Add(book_2);
                db.SaveChanges();
                Console.WriteLine("Objects saved...");
                var book = db.Books;
                Console.WriteLine("The list of books:");
                foreach (Book i in book)
                {
                    Console.WriteLine($"{i.BookID}. {i.Name}, {i.Author}");
                }

            }
            Console.ReadLine();
        }
    }
}
