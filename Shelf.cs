namespace Ex1.BookShelff
{
    internal class Shelf
    {
        Book[] books = new Book[10];
        int bookCount = -1;

        public Shelf() { }

        public int GetStoredQuantity()
        {
            return bookCount;
        }

        public bool AddBook(Book b)
        {
            if (books != null && bookCount < 9)
            {
                books[++bookCount] = b;
                return true;
            }

            return false;
        }

        public bool RemoveBook(int position)
        {
            if (position > -1 && position <= bookCount)
            {
                while (position < bookCount)
                    books[position++] = books[position];

                bookCount--;
                return true;
            }
            return false;
        }

        public void ShowBooks()
        {
            if (bookCount != -1)
            {
                Console.WriteLine($"\n-------------- Shelf --------------");
                for (int position = 0; position <= bookCount; position++)
                {
                    Console.WriteLine($"\n       Book {position + 1}");
                    books[position].ShowInfo();
                }
            }
            else
            {
                Console.WriteLine("The shelf is empty!");
            }
        }
    }
}
