
using MyLib;
class Program
{
    static void Main()
    {
        Clear();
        Library library = new Library();

        Book book1 = new Book("Clean Code", "Robert C. Martin", "12345");
        Book book2 = new Book("Design Patterns", "GoF", "67890");

        library.AddBook(book1);
        library.AddBook(book2);

        library.BorrowBook("Clean Code");
        library.BorrowBook("Clean Code"); 
        library.ReturnBook("Clean Code");
    }
}
