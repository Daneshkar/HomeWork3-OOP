namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("C# Programming", "Bill", "123-1-16-148410-0");
            Book book2 = new Book("Data Structures", "Azadi", "123-1-23-456789-7");
            Book book3 = new Book("Algorithms", "Ghomi", "123-1-12-345678-9");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.DisplayAllBooks();
            library.BorrowBook("C# Programming");
            library.BorrowBook("C# Programming");
            library.BorrowBook("Unknown Book");//err
            library.ReturnBook("C# Programming");
            library.ReturnBook("Data Structures"); //err
            Console.WriteLine("\nFinal status of books:");
            library.DisplayAllBooks();
        }
    }
}
