namespace RPGinConsole
{
    internal class DamageCalculator
    {
        private Random _random = new Random();

        public int CalculateDamage(int baseDamage, double criticalChance)
        {
            bool isCritical = _random.NextDouble() < criticalChance;
            return isCritical ? baseDamage * 2 : baseDamage;
        }
    }
}
