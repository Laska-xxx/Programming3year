namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet(2, 26, 7, new Cat());
            Pet pet1 = new Pet(10, 52, 16, new Dog());
            Pet pet2 = new Pet(3, 15, 3, new Crow());
            pet.MakeSound();
            pet1.MakeSound();
            pet2.MakeSound();
        }
    }
}
