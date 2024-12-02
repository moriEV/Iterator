using Iterator;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library();
        IEnumerator librarian = library.GetEnumerator();
        Book book1 = new Book();
        book1.Title = "Test1";
        book1.Author = "Test1";
        book1.Year = 1984;
        library.Add(book1);
        Book book2 = new Book();
        book2.Title = "Test2";
        book2.Author = "Test2";
        book2.Year = 1985;
        library.Add(book2);
        Book book3 = new Book();
        book3.Title = "Test3";
        book3.Author = "Test3";
        book3.Year = 1986;
        library.Add(book3);
        while (librarian.MoveNext())
        {
            Book book = (Book)librarian.Current;
            Console.WriteLine($"{book.Title}");
        }

    }
}