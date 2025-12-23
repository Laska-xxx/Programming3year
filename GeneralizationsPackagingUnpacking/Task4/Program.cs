namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(new Vector2(6, 7), 6);
            Circle circle1 = new Circle(new Vector2(0, 6), "7");
            Circle circle2 = new Circle(new Vector2(2, 3), 3.2);
            Circle circle3 = new Circle(new Vector2(1, 1), 2.4f);

            Console.WriteLine("-------Before change--------");

            Console.WriteLine(circle.ToString());
            Console.WriteLine(circle1.ToString());
            Console.WriteLine(circle2.ToString());
            Console.WriteLine(circle3.ToString());


            circle.SetRadius(6.7);
            circle1.SetRadius(7.2f);
            circle2.SetRadius("3");
            circle3.SetRadius(2.4);

            Console.WriteLine("-------After change--------");

            Console.WriteLine(circle.ToString());
            Console.WriteLine(circle1.ToString());
            Console.WriteLine(circle2.ToString());
            Console.WriteLine(circle3.ToString());
        }
    }
}
