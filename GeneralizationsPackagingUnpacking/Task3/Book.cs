using System.Globalization;

namespace Task3
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title}, Author - {Author}";
        }
    }
}
