namespace MyLib;

public class Library
{
    private List<Book> books = new();

    // add book to Lib
    public void AddBook(Book book)
    {
        books.Add(book);
        WriteLine($"Book  «{book.Title}» Added the library : {nameof(books)}.");
    }

    // امانت گرفتن کتاب
    public void BorrowBook(string title)
    {
        Book book = books.FirstOrDefault(b => b.Title == title);

        if (book == null)
        {
            WriteLine("Book not found.");
        }
        else if (!book.IsAvailable)
        {
            WriteLine("book this time not found");
        }
        else
        {
            book.IsAvailable = false;
            WriteLine($"book «{title}» transfer is successfully .");
        }
    }

    // بازگرداندن کتاب
    public void ReturnBook(string title)
    {
        Book book = books.FirstOrDefault(b => b.Title == title);

        if (book == null)
        {
            WriteLine("this book not a my library .");
        }
        else
        {
            book.IsAvailable = true;
            WriteLine($"book «{title}» back to the lib is succsessfully");
        }
    }
}

