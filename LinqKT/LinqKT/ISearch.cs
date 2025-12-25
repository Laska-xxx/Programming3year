namespace LinqKT
{
    internal interface ISearch
    {
        public abstract List<Book> Search(List<Book> books, string condition);
    }

    internal class ByTitleSearch : ISearch
    {
        public List<Book> Search(List<Book> books,  string condition)
        {
            return books.Where(b => b.Title == condition).ToList();;
        }
    }

    internal class ByAuthorSearch : ISearch
    {
        public List<Book> Search(List<Book> books, string condition)
        {
            return books.Where(b => b.Author == condition).ToList();
        }
    }

    internal class ByYearSearch : ISearch
    {
        public List<Book> Search(List<Book> books, string condition)
        {
            if (!int.TryParse(condition, out int intCondition))
            {
                Console.WriteLine("Uncorrect condition");
                return books;
            }
            return books.Where(b => b.Year == intCondition).ToList();
        }
    }

    internal class ByGenreSearch : ISearch
    {
        public List<Book> Search(List<Book> books, string condition)
        {
            return books.Where(b => b.Genre == condition).ToList();
        }
    }

    internal class SearchFactory
    {
        public readonly List<string> SearchType = new List<string>
        {
            "title",
            "author",
            "year",
            "genre"
        };

        private ByTitleSearch _byTitleSearch = new();
        private ByAuthorSearch _byAuthorSearch = new();
        private ByYearSearch _byYearSearch = new();
        private ByGenreSearch _byGenreSearch = new();

        public ISearch GetStrategy(string searchType)
        {
            switch (searchType.ToLower())
            {
                case ("title"):
                    return _byTitleSearch;
                case ("author"):
                    return _byAuthorSearch;
                case ("year"):
                    return _byYearSearch;
                case ("genre"):
                    return _byGenreSearch;
                default:
                    return _byTitleSearch;
            }
        }
    }

}
