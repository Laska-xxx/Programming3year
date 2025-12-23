namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle<int, string> rectangle = new Rectangle<int, string>(new Vector2(0, 0) ,2, "4");
            Rectangle<double, float> rectangle1 = new Rectangle<double, float>(new Vector2(1.5, 2.5), 3.3, 2.5f);
            Rectangle<float, string> rectangle2 = new Rectangle<float, string>(new Vector2(-2, 3), 4.2f, "3");

            Console.WriteLine("Rectangle 0");
            Console.WriteLine($"Min point: {rectangle.MinPoint().ToString()}");
            Console.WriteLine($"Max point: {rectangle.MaxPoint().ToString()}");

            Console.WriteLine("Rectangle 1");
            Console.WriteLine($"Min point: {rectangle1.MinPoint().ToString()}");
            Console.WriteLine($"Max point: {rectangle1.MaxPoint().ToString()}");

            Console.WriteLine("Rectangle 2");
            Console.WriteLine($"Min point: {rectangle2.MinPoint().ToString()}");
            Console.WriteLine($"Max point: {rectangle2.MaxPoint().ToString()}");
        }
    }
}