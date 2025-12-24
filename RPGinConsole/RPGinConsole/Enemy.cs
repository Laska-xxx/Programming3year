namespace RPGinConsole
{
    internal class Enemy : Creature
    {
        public int Experience { get; private set; }
        public Enemy(string name, int health, int attack, int level, int experience)
        {
            Name = name;
            CurHealth = health;
            AttackPower = attack;
            Level = level;
            Experience = experience;
        }

        public override string ToString()
        {
            return $"Enemy: {Name}" +
                $"\n     Level: {Level}" +
                $"\n     Health: {CurHealth}" +
                $"\n     Attack: {AttackPower}";
        }
    }
}
