namespace LinqKT
{
    internal class Library
    {
        public InfoWriter InfoWriter { get; private set; }
        private ReadersDatabase _readersDatabase;
        private BooksDatabase _booksDatabase;
        private SearchFactory _searchFactory;

        public Library()
        {
            _readersDatabase = new ReadersDatabase();
            _booksDatabase = new BooksDatabase();
            _searchFactory = new SearchFactory();
            InfoWriter = new InfoWriter(_booksDatabase.books);
        }

        public bool GetBook(int readerId, string bookTitle)
        {
            var book = _booksDatabase.books.FirstOrDefault(b => b.Title.ToLower() == bookTitle.ToLower());
            var reader = _readersDatabase.readers.FirstOrDefault(b => b.Id == readerId);

            if (book == null)
            {
                Console.WriteLine($"There is no book called {bookTitle}, please check the correctness of the input");
                return false;
            } 

            if (reader == null)
            {
                Console.WriteLine($"There is no reader under [ID: {bookTitle}], please check the correctness of the input");
                return false;
            }

            if (!book.IsAvailable)
            {
                Console.WriteLine($"The book you want to take is already borrowed to another reader");
                return false;
            }

            book.GetBook();
            reader.BorrowBook(book);
            Console.WriteLine($"The \"{book.Title}\" book has been successfully borrowed to the reader");
            return true;
        }

        public bool ReturnBook(int readerId, string bookTitle)
        {
            var book = _booksDatabase.books.FirstOrDefault(b => b.Title.ToLower() == bookTitle.ToLower());
            var reader = _readersDatabase.readers.FirstOrDefault(b => b.Id == readerId);

            if (book == null)
            {
                Console.WriteLine($"There is no book called {bookTitle}, please check the correctness of the input");
                return false;
            }

            if (reader == null)
            {
                Console.WriteLine($"There is no reader under [ID: {bookTitle}], please check the correctness of the input");
                return false;
            }

            if (book.IsAvailable || !reader.ReturnBook(book))
            {
                Console.WriteLine($"You have not the book what you want to return");
                return false;
            }

            book.ReturnBook();
            reader.ReturnBook(book);
            Console.WriteLine($"The \"{book.Title}\" book has been successfully return to the library");
            return true;
        }

        public bool Search(string type, string condition)
        {
            var strategy = _searchFactory.GetStrategy(type);

            if (strategy == null)
            {
                Console.WriteLine($"The \"{type}\" search type you entered does not exist, please check the correctness of the input");
                return false;
            }

            var results = strategy.Search(_booksDatabase.books, condition);

            Console.WriteLine($"-------Search results for {type} \"{condition}\"-------");
            if (results.Any())
            {
                foreach (var book in results)
                {
                    Console.WriteLine(book.ToString());
                }
            }
            else
            {
                Console.WriteLine("No books found");
            }

            return true;
        }

        public bool AddBook(string title, string author, int year, string genre)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Title and author cannot be empty");
                return false;
            }

            if (year < 0 )
            {
                Console.WriteLine($"You have entered an invalid year value: {year}, please check the correctness of the input");
                return false;
            }

            if (_booksDatabase.books.Any(b =>
                b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) &&
                b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Book '{title}' by {author} already exists in the library");
                return false;
            }

            _booksDatabase.AddBook(title, author, year, genre);
            Console.WriteLine($"Book \"{title}\" by {author} ({year}) added successfully");
            return true;
        }

        public bool AddReader(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Reader name cannot be empty");
                return false;
            }

            Console.WriteLine($"Reader '{name}' added successfully");
            return true;
        }

        public void ShowAllBooks()
        {
            foreach (var book in _booksDatabase.books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public void ShowAllReaders()
        {
            foreach (var reader in _readersDatabase.readers)
            {
                Console.WriteLine(reader.ToString());

                if (reader.BorrowedBooks.Any())
                {
                    Console.WriteLine("  Borrowed books:");

                    foreach (var book in reader.BorrowedBooks)
                    {
                        Console.WriteLine($" - {book.Title}");
                    }
                }
            }
        }
    }
}
