namespace RPGinConsole
{
    internal class CharacterCreationState : IGameState
    {
        public void Handle(GameContext context)
        {   
            PlayerBuilder builder = new PlayerBuilder();

            Console.Write("--------Character creation--------\nEnter your character name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Enter your character class index:");

            bool correctEnter = false;

            while (!correctEnter)
            {
                Console.WriteLine("     1 - Warrior (Health: 200, Power: 15, Crit: 10%)" +
                    "\n     2 - Magician (Health: 120, Power: 25, Crit: 15%)" +
                    "\n     3 - Archer (Health: 150, Power: 20, Crit: 20%)");
                Console.Write("Your choose: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        builder.SetClass("Warrior");
                        builder.SetHealth(200);
                        builder.SetAttack(15);
                        builder.SetCriticalChance(0.1f);
                        correctEnter = true;
                        break;
                    case "2":
                        builder.SetClass("Magician");
                        builder.SetHealth(120);
                        builder.SetAttack(25);
                        builder.SetCriticalChance(0.15f);
                        correctEnter = true;
                        break;
                    case "3":
                        builder.SetClass("Archer");
                        builder.SetHealth(150);
                        builder.SetAttack(20);
                        builder.SetCriticalChance(0.2f);
                        correctEnter = true;
                        break;
                    default:
                        Console.WriteLine("Please, enter only 1 or 2 or 3");
                        break;
                }
            }

            context.Player = builder.Build(name);

            Console.WriteLine("Character  has been created");
            Console.WriteLine(context.Player.ToString());
            Console.WriteLine("\nPress any key to start battl...");
            Console.ReadKey();

            context.State = new BattleState();
        }
    }
}
