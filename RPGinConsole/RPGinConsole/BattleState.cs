namespace RPGinConsole
{
    internal class BattleState : IGameState
    {
        public void Handle(GameContext context)
        {
            if (context.CurrentEnemy == null || !context.CurrentEnemy.IsAlive)
            {
                context.CurrentEnemy = context.EnemyFactory.CreateMonster();

                Console.WriteLine($"--------The battle has begun!--------");
                Console.WriteLine($"{context.CurrentEnemy.ToString()}");
                Console.WriteLine("Press any key to next...");
                Console.ReadKey();
            }

            Player player = context.Player;
            Enemy enemy = context.CurrentEnemy;

            DisplayStats(player, context);

            Battle(player, enemy, context);

            if (context.Player.HasWon)
            {
                context.State = new GameOverState(true);
            }
            else if (!context.Player.IsAlive)
            {
                context.State = new GameOverState(false);
            }
            else if (!enemy.IsAlive)
            {
                context.State = new BetweenBattlesState();
            }
        }

        private void Battle(Player player, Enemy enemy, GameContext context)
        {
            Console.WriteLine("--------Your Turn--------");

            int playerDamage = context.DamageCalculator.CalculateDamage(player.AttackPower, player.CriticalChance);
            enemy.TakeDamage(playerDamage);
            Console.WriteLine($"You have done {enemy.Name} the {playerDamage} damage");

            Console.WriteLine("Press any key to next...");
            Console.ReadKey();


            if (!enemy.IsAlive)
            {
                Console.WriteLine($"------You are won {enemy.Name}!------");

                player.AddExperience(enemy.Experience);
                player.AddEnemyDefeated();

                Console.WriteLine($"You get {enemy.Experience} exp");
                Console.WriteLine($"Enemy defeated: {player.EnemysDefeated}/15");
                return;
            }

            Console.WriteLine("--------Enemy Turn--------");

            player.TakeDamage(enemy.AttackPower);
            Console.WriteLine($"{enemy.Name} has dealt you {enemy.AttackPower} damage");

            Console.WriteLine("Press any key to next...");
            Console.ReadKey();
        }

        private void DisplayStats(Player player, GameContext context)
        {
            Console.WriteLine(context.InfoWriter.StatsInfo(player));
        }
    }
}
