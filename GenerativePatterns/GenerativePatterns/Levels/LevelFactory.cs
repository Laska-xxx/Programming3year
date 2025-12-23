using GenerativePatterns.Creaturs;

namespace GenerativePatterns.Levels
{
    internal abstract class LevelFactory
    {
        protected Random Random = new Random();

        public string LevelName { get; protected set; }
        public int Difficulty { get; protected set; }
        public int MinEnemysOnLevel { get; protected set; }
        public int MaxEnemyOnLevel { get; protected set; }

        public abstract List<Enemy> CreateEnemys();

        public override string ToString()
        {
            return $"------------Level Info------------\n{LevelName} - difficulty: {Difficulty}, enemy count {MinEnemysOnLevel}-{MaxEnemyOnLevel}";
        }

        protected abstract Enemy CreateEnemy();

    }
}
