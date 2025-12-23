using GenerativePatterns.Creaturs;
using GenerativePatterns.Levels;

namespace GenerativePatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LevelCreator levelCreator = new LevelCreator();

            List<LevelFactory> levelFactories = new List<LevelFactory>
            {
                new EasyLevel(),
                new MediumLevel(),
                new HardLevel()
            };

            int levelNumber;

            Console.WriteLine("Easy level - 1\nMedium level - 2\nHard leel - 3\nEnter level num: ");
            while (!int.TryParse(Console.ReadLine(), out levelNumber) || levelNumber < 0 || levelNumber > levelFactories.Count)
            {
                Console.WriteLine("Easy level - 1\nMedium level - 2\nHard leel - 3\n" +
                    "Select one of these and enter the appropriate number.");
            }

            levelCreator.SetLevel(levelFactories[levelNumber - 1]);

            Console.WriteLine(levelCreator.ShowLevelInfo());

            List<Enemy> enemys = levelCreator.BildLevel();

            Console.WriteLine("-------Enemies on the level-------");
            foreach (Enemy enemy in enemys)
            {
                Console.WriteLine(enemy.ToString());
            }

            Console.WriteLine("Enemy attack you!");
            Console.WriteLine(enemys[0].Attack());
        }
    }
}
/*

Сделать создатель разных уровней сложности с рандомом количества монстров их силой и классом(Пчёлы, волки, медведи)

Реализовать ввод пользователя, пользователь вводит цифру уровня сложности.

Под отдельный уровень создаём отдельную фабрику

*/