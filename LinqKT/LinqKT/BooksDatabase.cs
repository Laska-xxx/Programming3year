namespace LinqKT
{
    internal class BooksDatabase
    {
        public List<Book> books { get; private set; }

        public BooksDatabase()
        {
            books = new()
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Classic"),
                new Book("To Kill a Mockingbird", "Harper Lee", 1960, "Fiction"),
                new Book("1984", "George Orwell", 1949, "Dystopian"),
                new Book("Pride and Prejudice", "Jane Austen", 1813, "Romance"),
                new Book("The Catcher in the Rye", "J.D. Salinger", 1951, "Coming-of-age"),
                new Book("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy"),
                new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997, "Fantasy"),
                new Book("The Da Vinci Code", "Dan Brown", 2003, "Thriller"),
                new Book("The Alchemist", "Paulo Coelho", 1988, "Philosophical"),
                new Book("Gone with the Wind", "Margaret Mitchell", 1936, "Historical Fiction")
            };
        }

        public void AddBook(string title, string author, int year, string genre)
        {
            books.Add(new Book(title, author, year, genre));
        }
    }
}