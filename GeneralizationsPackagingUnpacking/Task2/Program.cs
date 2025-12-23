namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string> book = new Book<string>("Fahrenheit 451", 300, "Ray Bradbury", "T6TGC");
            Book<string> book1 = new Book<string>("Kolobok", 50, "People", "U7SDD");

            Book<int> book2 = new Book<int>("Fight Club", 200, "Chuck Palahniuk", 11056);
            Book<int> book3 = new Book<int>("Crime and punishment", 100, "Fyodor Dostoevsky", 050389);

            Book<Guid> book4 = new Book<Guid>("The Hobbit", 250, "John Ronald", Guid.NewGuid());
            Book<Guid> book5 = new Book<Guid>("Hellsing", 100, "Kouta Hirano", Guid.NewGuid());

            Console.WriteLine(book);
            Console.WriteLine(book1);

            Console.WriteLine(book2);
            Console.WriteLine(book3);

            Console.WriteLine(book4);
            Console.WriteLine(book5);
        }
    }
}
