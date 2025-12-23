using GenerativePatterns.Creaturs;

namespace GenerativePatterns.Levels
{
    internal class EasyLevel : LevelFactory
    {
        public EasyLevel()
        {
            LevelName = "Easy Level";
            Difficulty = 1;
            MinEnemysOnLevel = 1;
            MaxEnemyOnLevel = 5;
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
            int enemyPower = Random.Next(1, 3);
            int enemyHealth = Random.Next(enemyPower * 5);
            
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
