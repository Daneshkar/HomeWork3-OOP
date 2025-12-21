using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public void BorrowBook(string title)
        {
            Book book = FindBook(title);
            if (book == null)
            {
                Console.WriteLine($"Book with title '{title}' not found.");
                return;
            }

            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"You have borrowed '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available.");
            }
        }

        public void ReturnBook(string title)
        {
            Book book = FindBook(title);
            if (book == null)
            {
                Console.WriteLine($"Book with title '{title}' not found.");
                return;
            }

            if (!book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.WriteLine($"Thank you for returning '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"This book '{book.Title}' was not borrowed.");
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }

        private Book FindBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
