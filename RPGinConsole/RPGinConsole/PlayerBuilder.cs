namespace RPGinConsole
{
    internal class PlayerBuilder
    {
        private string _name;
        private string _heroClass;
        private int _health;
        private int _attack;
        private float _criticalChance;

        public void SetHealth(int health)
        {
            _health = health;
        }

        public void SetClass(string classe)
        {
            _heroClass = classe;
        }

        public void SetAttack(int attack)
        {
            _attack = attack;
        }

        public void SetCriticalChance(float criticalChance)
        {
            _criticalChance = criticalChance;
        }

        public Player Build(string name)
        {
            _name = name;
            return new Player(_name, _heroClass, _health, _attack, _criticalChance);
        }
    }
}
