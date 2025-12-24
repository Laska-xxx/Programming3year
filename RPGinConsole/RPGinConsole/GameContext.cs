namespace RPGinConsole
{
    internal class GameContext
    {
        public Player Player { get; set; }
        public Enemy CurrentEnemy { get; set; }
        public InfoWriter InfoWriter { get; set; }
        public DamageCalculator DamageCalculator { get; set; }
        public EnemyFactory EnemyFactory { get; set; }
        public IGameState State { get; set; }
        public bool ExitGame = false;

        public GameContext()
        {
            InfoWriter = new InfoWriter();
            DamageCalculator = new DamageCalculator();
            EnemyFactory = new EnemyFactory();
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}
