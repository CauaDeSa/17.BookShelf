namespace Ex1.BookShelff
{
    internal class Book
    {
        public string title;
        public string author;
        public DateOnly releaseDate;
        public string publisher;
        public string edition;
        public string isbn;
        public int pageQuantity;

        public Book() { }

        public void SetTitle(string title) { this.title = title; }
        public void SetAuthor(string author) { this.author = author; }
        public void SetReleaseDate(DateOnly releaseDate) { this.releaseDate = releaseDate; }
        public void SetPublisher(string publisher) { this.publisher = publisher; }
        public void SetEdition(string edition) { this.edition = edition; }
        public void SetIsbn(string isbn) { this.isbn = isbn; }
        public void SetPageQuantity(int quantity) { this.pageQuantity = quantity; }

        public void ShowInfo()
        {
            Console.WriteLine($"\nBook Title......:{this.title}");
            Console.WriteLine($"Author..........:{this.author}");
            Console.WriteLine($"Release date....:{this.releaseDate}");
            Console.WriteLine($"Publisher.......:{this.publisher}");
            Console.WriteLine($"Edition.........:{this.edition}");
            Console.WriteLine($"ISBN............:{this.isbn}");
            Console.WriteLine($"Page quantity...:{this.pageQuantity}");
        }
    }
}
