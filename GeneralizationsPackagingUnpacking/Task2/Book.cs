namespace Task2
{
    internal class Book<T>
    {
        public string Name { get; }
        public int PagesCount { get; }
        public string Author { get; }
        public T Id { get; }

        public Book(string name, int pagesCount, string author, T iD)
        {
            Name = name;
            PagesCount = pagesCount;
            Author = author;
            Id = iD;
        }

        public override string ToString()
        {
            return $"{Id} {Name}, {Author}, {PagesCount} страниц.";
        }
    }
}
