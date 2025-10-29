namespace Patterns.Ex5
{
    internal class RealService : IService
    {
        public string GetData(string request)
        {
            Console.WriteLine("Выполняется запрос");

            Thread.Sleep(3000);

            Console.WriteLine($"Запрос выполнен");
            return request;
        }
    }
}
