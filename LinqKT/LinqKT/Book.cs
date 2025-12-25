namespace LinqKT
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public string Genre { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            IsAvailable = true;
        }

        public void GetBook()
        {
            IsAvailable = false;
        }

        public void ReturnBook()
        {
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"{Title}  [{Author}, {Year}] - Genre: {Genre}, Is avalable: {(IsAvailable ? "Available" : "Unavailable")}";
        }
    }
}