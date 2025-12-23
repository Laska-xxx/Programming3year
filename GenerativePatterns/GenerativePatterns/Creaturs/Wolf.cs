namespace GenerativePatterns.Creaturs
{
    internal class Wolf : Enemy
    {
        public Wolf(int power, int health) : base(power, health)
        {
            Name = "Hungry Wolf";
        }

        public override string Attack()
        {
            return $"{Name} bites you with a force of {Power}";
        }
    }
}
/* монстров их силой и классом(Пчёлы, волки, медведи)*/