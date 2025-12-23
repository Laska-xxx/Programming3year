using GenerativePatterns.Creaturs;

namespace GenerativePatterns.Levels
{
    internal class LevelCreator
    {
        private LevelFactory levelFactory;

        public void SetLevel(LevelFactory factory)
        {
            levelFactory = factory;
        }
        
        public List<Enemy> BildLevel()
        {
            return levelFactory.CreateEnemys();
        }

        public string ShowLevelInfo()
        {
            return levelFactory.ToString();
        }

    }
}
