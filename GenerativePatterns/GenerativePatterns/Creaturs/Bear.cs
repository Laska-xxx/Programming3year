namespace GenerativePatterns.Creaturs
{
    internal class Bear : Enemy
    {
        public Bear(int power, int health) : base(power, health)
        {
            Name = "Sleepy Bear";
        }

        public override string Attack()
        {
            return $"{Name} beats you with a force of {Power}";
        }
    }
}
/* монстров их силой и классом(Пчёлы, волки, медведи)*/