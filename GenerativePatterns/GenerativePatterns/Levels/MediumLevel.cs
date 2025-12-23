using GenerativePatterns.Creaturs;

namespace GenerativePatterns.Levels
{
    internal class MediumLevel : LevelFactory
    {
        public MediumLevel()
        {
            LevelName = "Medium Level";
            Difficulty = 2;
            MinEnemysOnLevel = 5;
            MaxEnemyOnLevel = 10;
        }

        public override List<Enemy> CreateEnemys()
        {
            List<Enemy> enemies = new List<Enemy>();

            for (int i = 0; i < Random.Next(MinEnemysOnLevel, MinEnemysOnLevel + 1); i++)
            {
                enemies.Add(CreateEnemy());
            }
            return enemies;
        }

        protected override Enemy CreateEnemy()
        {
            int enemyType = Random.Next(0, 3);
            int enemyPower = Random.Next(3, 6);
            int enemyHealth = Random.Next( enemyPower ,enemyPower * 3);

            switch (enemyType)
            {
                case 0:
                    return new Bee(enemyPower, enemyHealth);
                case 1:
                    return new Wolf(enemyPower, enemyHealth);
                case 2:
                    return new Bear(enemyPower, enemyHealth);
                default:
                    return new Bee(enemyPower, enemyHealth);
            }
        }
    }
}
