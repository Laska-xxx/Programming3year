namespace RPGinConsole
{
    internal class LevelUpState : IGameState
    {
        public void Handle(GameContext context)
        {
            if (context.Player.Experience >= context.Player.ExperienceToNextLevel)
            {
                context.Player.LevelUp();

                Console.WriteLine("--------Level Up--------");
                Console.WriteLine($"You have reached level {context.Player.Level}!");
                Console.WriteLine($"Enter your choose an improvement:" +
                    $"\n     1 - Max health +20" +
                    $"\n     2 - Attack power +5" +
                    $"\n     3 - Crit change +5%");

                bool correctEnter = true;

                while (correctEnter)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            context.Player.IncreaseHealth();
                            Console.WriteLine("Your max health is increased");
                            correctEnter = false;
                            break;
                        case "2":
                            context.Player.IncreaseAttack();
                            Console.WriteLine("Your attsck power is increased");
                            correctEnter = false;
                            break;
                        case "3":
                            context.Player.IncreaseCriticalChance();
                            Console.WriteLine("Your crit change is increased");
                            correctEnter = false;
                            break;
                        default:
                            Console.WriteLine($"Please, enter only 1 or 2 or 3 for choose" +
                                $"\n     1 - Max health +20" +
                                $"\n     2 - Attack power +5" +
                                $"\n     3 - Crit change +5%");
                            break;
                    }
                }

                Console.Write("Press any key to continue");
                Console.ReadKey();
            }

            context.State = new BattleState();
        }
    }
}
