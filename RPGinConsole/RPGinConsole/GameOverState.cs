namespace RPGinConsole
{
    internal class GameOverState : IGameState
    {
        private bool _isVictory;

        public GameOverState(bool isVictory)
        {
            _isVictory = isVictory;
        }

        public void Handle(GameContext context)
        {
            if (_isVictory)
            {
                Console.WriteLine("--------You Won!--------");
            }
            else
            {
                Console.WriteLine("--------You Lost!--------");
            }

            Console.WriteLine($"\nYour stats:");
            Console.WriteLine(context.InfoWriter.GameEndInfo(context.Player));

            Console.Write("Press any key to continue");
            Console.ReadKey();

            context.State = new MainMenuState();
        }
    }
}
