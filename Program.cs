using Ex1.BookShelff;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int menuChoose, bookIndex;
        Shelf shelf = new Shelf();

        MockData(shelf);

        do
        {
            do
            {
                ClearScreen();
                ShowMenu();
                Console.Write("\nOption: ");
                menuChoose = int.Parse(Console.ReadLine());

            } while (menuChoose < 0 || menuChoose > 3);

            switch (menuChoose)
            {
                case 0:
                    ClearScreen();
                    shelf.ShowBooks();
                    Console.Write("\nPress any key to continue");
                    Console.ReadKey();
                    break;

                case 1:
                    shelf.AddBook(RegisterBook());
                    break;

                case 2:
                    do
                    {
                        ClearScreen();
                        Console.Write("Type the number of the book that should be removed: ");
                        bookIndex = int.Parse(Console.ReadLine());
                    } while (bookIndex < 0 || bookIndex > 9);

                    if (shelf.RemoveBook(bookIndex - 1))
                        Console.WriteLine("\nBook successfully removed!");
                    else
                        Console.WriteLine("\nWe can't remove a book we don't have!");
                    Console.Write("\nPress any key to continue");
                    Console.ReadKey();
                    break;
            }

        } while (menuChoose != 3);
    }

    static void MockData(Shelf shelf)
    {
        string[] titles = new string[4] { "Harry", "Potter", "Hobbit", "Game Of Thrones" };
        string[] authors = new string[4] { "J.K.", "Rowling", "Tolkien", "Martin" };
        string[] dates = new string[4] { "1965/07/31", "1965/07/30", "1937/09/21", "1996/08/6" };
        string[] publishers = new string[4] { "Blooms", "bury", "Allen & Unwin", "Sei la" };
        string[] editions = new string[4] { "1", "2", "3", "4" };
        string[] isbns = new string[4] { "978-0-439-02348-1", "009-0-439-02348-1", "070-439-02348-1", "800-0-439-02348-1" };
        int[] pageQuantitys = new int[4] { 310, 197, 139, 686 };

        for (int i = 0; i < 4; i++)
        {
            Book book = new Book();

            book.SetTitle(titles[i]);
            book.SetAuthor(authors[i]);
            book.SetReleaseDate(DateOnly.Parse(dates[i]));
            book.SetPublisher(publishers[i]);
            book.SetEdition(editions[i]);
            book.SetIsbn(isbns[i]);
            book.SetPageQuantity(pageQuantitys[i]);

            shelf.AddBook(book);
        }
    }

    static void ClearScreen()
    {
        Console.Clear();
        Console.WriteLine("  ____              _       _____ _          _  __ \r\n |  _ \\            | |     / ____| |        | |/ _|\r\n | |_) | ___   ___ | | __ | (___ | |__   ___| | |_ \r\n |  _ < / _ \\ / _ \\| |/ /  \\___ \\| '_ \\ / _ \\ |  _|\r\n | |_) | (_) | (_) |   <   ____) | | | |  __/ | |  \r\n |____/ \\___/ \\___/|_|\\_\\ |_____/|_| |_|\\___|_|_|  \r\n                                                   \r\n                                                   ");
    }

    static void ShowMenu()
    {
        Console.WriteLine("[0] View all books");
        Console.WriteLine("[1] Add book");
        Console.WriteLine("[2] Remove book by index");
        Console.WriteLine("[3] Exit");
    }

    static Book RegisterBook()
    {
        Book book = new Book();

        ClearScreen();
        Console.WriteLine($"----- Book Register -----\n");

        Console.Write("Type title: ");
        book.SetTitle(Console.ReadLine());

        Console.Write("Type author(s) name ");
        book.SetAuthor(Console.ReadLine());

        Console.Write("Type release date: ");
        book.SetReleaseDate(DateOnly.Parse(Console.ReadLine()));

        Console.Write("Type publisher: ");
        book.SetPublisher(Console.ReadLine());

        Console.Write("Type edition: ");
        book.SetEdition(Console.ReadLine());

        Console.Write("Type isbn: ");
        book.SetIsbn(Console.ReadLine());

        Console.Write("Type page quantity: ");
        book.SetPageQuantity(int.Parse(Console.ReadLine()));

        return book;
    }
}