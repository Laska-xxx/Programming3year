using static System.Reflection.Metadata.BlobBuilder;

namespace LinqKT
{
    internal class InfoWriter
    {
        private List<Book> _books;

        public InfoWriter(List<Book> books)
        {
            _books = books;
        }

        public string AvailableBooks()
        {
            var availableBooks = _books
            .Where(b => b.IsAvailable);

            if (!availableBooks.Any())
            {
                return "There are no available books";
            }

            string result = "----------Available Books-----------\n";

            foreach (var book in availableBooks)
            {
                result += $"{book.ToString()}\n";
            }

            return result;
        }

        public string OneGenreBooks(string genre)
        {
            var oneGenreBooks = _books
            .Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));

            string coolGenre = genre.Substring(0, 1).ToUpper() + genre.Substring(1);

            if (!oneGenreBooks.Any())
            {
                return $"There are no {coolGenre} books";
            }

            string result = $"----------\"{coolGenre}\" Genre Books-----------\n";

            foreach (var book in oneGenreBooks)
            {
                result += $"{book.ToString()}\n";
            }

            return result;
        }

        public string TopOldesBooks()
        {
            var oldestBooks = _books
            .OrderBy(b => b.Year)
            .Take(3)
            .ToList();

            if (!oldestBooks.Any())
                return "No books in the library";

            var result = $"----------Top 3 Oldes Books----------\n";

            for (int i = 0; i < oldestBooks.Count; i++)
            {
                result += $"TOP {i + 1} - {oldestBooks[i].ToString()}\n";
            }

            return result;
        }

        public string OneAuthorBooks(string author)
        {
            var authorBooks = _books
            .Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));

            string coolAuthor = author.Substring(0, 1).ToUpper() + author.Substring(1);
            
            if (!authorBooks.Any())
                return $"No books found by {coolAuthor}";

            

            var result = $"----------Books By {coolAuthor}----------\n";

            foreach (var book in authorBooks)
            {
                result += $"{book.ToString()}\n";
            }

            return result;
        }
    }
}
