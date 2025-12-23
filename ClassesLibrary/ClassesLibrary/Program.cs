using ElenaZYa_CatFramework;
using System.IO;

namespace ElenaZYa_CatApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint catCount;

            Console.WriteLine("Enter the desired count of cats: ");

            while (!uint.TryParse(Console.ReadLine(), out catCount))
            {
                Console.WriteLine("Enter a positive count of cats!");
            }

            Cat[] cats = GenerateRandomCats(catCount);

            Console.WriteLine("All cats have been successfully created!");

            Console.Write("Enter the path to the file where you want to save information about cats: ");
            string filePath = Console.ReadLine();

            try
            {
                DisplayCatInfo(cats, filePath);
                Console.WriteLine($"Information about cats is saved");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Save exception: {ex.Message}");
            }
        }

        static Cat[] GenerateRandomCats(uint count)
        {
            Cat[] cats = new Cat[count];
            Random random = new Random();
            int curCount = 0;

            while (curCount < count)
            {
                try
                {
                    if (random.Next(2) == 0)
                    {
                        int fluffiness = random.Next(-20, 121);
                        cats[curCount] = new CuteCat(fluffiness);
                        
                    }

                    else
                    {
                        int fluffiness = random.Next(-20, 121);
                        double weight = random.Next(50, 161) + random.NextDouble();
                        cats[curCount] = new Tiger(fluffiness, weight);
                    }

                    curCount++;
                }

                catch (CatException ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }

            return cats;
        }

        static void DisplayCatInfo(Cat[] catsArr, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (var cat in catsArr)
                {
                    string info = $"{cat.ToString()}\nFluffiness check: {cat.FluffinessCheck()}";
                    Console.WriteLine(info);

                    writer.WriteLine(info);
                }
            }

        }
    }
}
/*
Напишите метод Cat[] GenerateRandomCats(uint count) – генерирует случайным образом массив 
 *  кошачьих заданного размера. Каждый из элементов массива равновероятно генерируется как Tiger или как CuteCat. 
 *  При этом при создании объектов программа должна пытаться передать в конструктор значения fluffiness [-20; 120], 
 *  а weight (только для тигра) – [50; 160]. При каждом возникновении исключения CatException программа должна написать 
 *  на консоль, что возникло исключение и его текст, а попытки генерации объектов должны повторяться до тех пор, 
 *  пока весь массив не будет создан корректно и возвращён.
В методе Main введите число catCount – количество генерируемых объектов и сохраните результат вызова GenerateRandomCats.
Напишите метод void DisplayCatInfo(Cat[] catsArr, string path) – он должен печатать результаты вызова методов 
 *  FluffinessCheck() и ToString() для каждого объекта массива catsArr на консоль И В ФАЙЛ, расположенный по пути path. 
 *  Если по заданному пути файл уже существует, перепишите его.
Из метода Main введите с консоли путь к файлу, передайте его и массив Cat[] в метод DisplayCatInfo.*/