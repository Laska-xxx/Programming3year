namespace RepeatingOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList array = new IntArrayList(5);

            for (int i = 0; i < 10; i++)
            {
                array.PushBack(i);
            }

            array.PopBack();

            Console.WriteLine(array.TryInsert(11, 7));
            Console.WriteLine(array.TryInsert(6, 7));

            Console.WriteLine(array.TryErase(11));
            Console.WriteLine(array.TryErase(6));

            Console.WriteLine(array.TryGetAt(11, out int res1));
            Console.WriteLine(res1);
            Console.WriteLine(array.TryGetAt(6, out int res2));
            Console.WriteLine(res2);

            Console.WriteLine(array.TryForceCapacity(-3));
            Console.WriteLine(array.TryForceCapacity(15));

            Console.WriteLine(array.Find(30));
            Console.WriteLine(array.Find(7));
        }
    }
}
