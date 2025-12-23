namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            PackingUnpacking packingUnpacking = new PackingUnpacking();
            List<object> list = new List<object>();

            Console.WriteLine("Enter length of list:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (random.Next(2) == 0)
                {
                    list.Add(random.Next(1, 101));
                }
                else
                {
                    list.Add((float)(random.NextDouble() * 100));
                }
            }

            float result = packingUnpacking.CalculateSum(list);
            Console.WriteLine($"Sum: {result}");
        }
    }
}
