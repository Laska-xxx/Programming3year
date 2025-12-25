namespace LinqKT
{
    internal class Reader
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<Book> BorrowedBooks { get; private set; }

        public Reader(int id, string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (!BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Add(book);
            }   
        }

        public bool ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                return true;
            }
                
            return false;
        }

        public override string ToString()
        {
            return $"{Name} [ID: {Id}] - Borrowed books: {BorrowedBooks.Count}";
        }
    }
}