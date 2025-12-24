namespace RPGinConsole
{
    internal abstract class Creature
    {
        public string Name { get; protected set; }
        public int CurHealth { get; protected set; }
        public int AttackPower { get; protected set; }
        public int Level { get; protected set; }
        public bool IsAlive
        {
            get { return CurHealth > 0; }
        }

        public void TakeDamage(int damage)
        {
            CurHealth -= damage;
            if (CurHealth < 0) CurHealth = 0;
        }
    }
}
