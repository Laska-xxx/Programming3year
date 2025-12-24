namespace RPGinConsole
{
    internal class MainMenuState : IGameState
    {
        public void Handle(GameContext context)
        {
            Console.WriteLine("--------RPG GAME--------\nEnter your choose:\n1 - Start new game\n0 - Exit");

            string choice;
            bool correctEnter = false;

            switch (Console.ReadLine())
            {
                case "1":
                    context.State = new CharacterCreationState();
                    break;
                case "0":
                    context.ExitGame = true;    
                    break;
                default:
                    Console.WriteLine("Please, enter only 1 or 2!\n1 - Start new game\n0 - Exit");
                    return;
            }
        }
    }
}
