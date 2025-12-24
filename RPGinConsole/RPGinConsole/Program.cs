namespace RPGinConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameContext context = new GameContext();
            context.State = new MainMenuState();

            while (!context.ExitGame)
            {
                context.Request();
            }
        }
    }
}
