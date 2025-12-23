namespace StructuralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHome smartHome = new SmartHome();

            List<string> modsList = new List<string>
            {
                "default",
                "Night",
                "Morning",
                "Chill"
            };

            int modeIndex;

            Console.WriteLine("Enter the index of the desired mod" +
                    "\nNight - 1\nMorning - 2\nChill - 3\nDefault - 0");

            while (!int.TryParse(Console.ReadLine(), out modeIndex) || modeIndex < 0
            || modeIndex >= modsList.Count)
            {
                Console.WriteLine("Please, enter the index of the mode." +
                    "\nNight - 1\nMorning - 2\nChill - 3\nDefault - 0");
            }

            smartHome.SetUpHome(modsList[modeIndex]);
        }
    }
}