namespace GenerativePatterns.Creaturs
{
    internal class Bee : Enemy
    {
        public Bee(int power, int health) : base(power, health)
        {
            Name  = "Angry Bee";
        }

        public override string Attack()
        {
            return $"{Name} stings you with a force of {Power}";
        }
    }
}
/* монстров их силой и классом(Пчёлы, волки, медведи)*/