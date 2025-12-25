namespace LinqKT
{
    internal class ReadersDatabase
    {
        public List<Reader> readers { get; private set; }

        public ReadersDatabase()
        {
            readers = new()
            {
                new Reader(1, "John Smith"),
                new Reader(2, "Emily Johnson"),
                new Reader(3, "Michael Williams"),
                new Reader(4, "Sarah Brown"),
                new Reader(5, "David Jones")
            };
        }

        public void AddReader(string name)
        {
            readers.Add(new Reader(readers.Count, name));
        }
    }
}