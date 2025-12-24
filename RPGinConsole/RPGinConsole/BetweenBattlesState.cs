using System.Diagnostics.Metrics;
using System.Numerics;

namespace RPGinConsole
{
    internal class BetweenBattlesState : IGameState
    {
        public void Handle(GameContext context)
        {
            Player player = context.Player;

            if (player.CurHeal < player.Heals)
            {
                Console.WriteLine($"After battl you can heal yourself if you want" +
                    $"\nYour current health: {player.CurHealth}" +
                    $"\nEnter your choose:" +
                    $"\n     1 - Heal ({player.Heals - player.CurHeal}/{player.Heals})" +
                    $"\n     0 - Nothing");

                switch (Console.ReadLine())
                {
                    case "1":
                        context.Player.Heal();
                        Console.WriteLine($"You have regained your health, current health: {player.Health}");
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Please enter only 1 or 0:" +
                        $"\n     Heal  ({context.Player.Heals - player.CurHeal}/{player.Heals})" +
                        $"\n     Nothing");
                        return;
                }
            }

            if (player.Experience >= player.ExperienceToNextLevel)
            {
                player.LevelUp();

                Console.WriteLine("--------Level Up--------");
                Console.WriteLine($"You have reached level {player.Level}!");
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
                            player.IncreaseHealth();
                            Console.WriteLine("Your max health is increased");
                            correctEnter = false;
                            break;
                        case "2":
                            player.IncreaseAttack();
                            Console.WriteLine("Your attsck power is increased");
                            correctEnter = false;
                            break;
                        case "3":
                            player.IncreaseCriticalChance();
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
