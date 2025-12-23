namespace GenerativePatterns.Creaturs
{
    internal abstract class Enemy
    {
        public string Name { get; protected set; }
        public int Power { get; protected set; }
        public int Health { get; protected set; }

        public Enemy(int power, int health)
        {
            Power = power;
            Health = health;
        }

        public abstract string Attack();

        public override string ToString()
        {
            return $"{Name} - power: {Power}, health: {Health}";
        }
    }
}
/* монстров их силой и классом(Пчёлы, волки, медведи)*/