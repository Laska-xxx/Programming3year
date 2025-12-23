namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneralizedClass<int> intExample = new GeneralizedClass<int>(67);
            GeneralizedClass<Book> bookExample = new GeneralizedClass<Book>(new Book("Winnie the Pooh", "Ernest Shepard"));

            Console.WriteLine("---------Before reset----------");
            Console.WriteLine($"Int example: {intExample.Value}");
            Console.WriteLine($"Book exaple: {bookExample.Value}");

            intExample.Reset();
            bookExample.Reset();

            Console.WriteLine("---------After reset----------");
            Console.WriteLine($"Int example: {intExample.Value}");
            Console.WriteLine($"Book exaple: {bookExample.Value}");
        }
    }
}
