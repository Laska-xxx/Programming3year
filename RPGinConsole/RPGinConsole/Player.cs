namespace RPGinConsole
{
    internal class Player : Creature
    {   
        public bool CanHeal
        {
            get { return CurHeal < Heals; }
        }
        public bool HasWon
        {
            get { return EnemysDefeated >= 15; }
        }

        public string Class { get; private set; }
        public int Health { get; private set; }
        public float CriticalChance { get; private set; }
        public int Experience { get; private set; }
        public int ExperienceToNextLevel { get; private set; }
        public int EnemysDefeated { get; private set; }
        public int CurHeal { get; private set; }
        public int Heals { get; private set; } = 3;

        public Player(string name, string heroClass, int health, int attack, float criticalChance)
        {
            Name = name;
            Class = heroClass;
            CurHealth = health;
            Health = health;
            AttackPower = attack;
            CriticalChance = criticalChance;
            Level = 1;
            Experience = 0;
            ExperienceToNextLevel = 100;
            EnemysDefeated = 0;
            CurHeal = 0;
        }

        public bool Heal()
        {
            if (CurHeal >= Heals || CurHealth >= Health)
            {
                return false;
            }

            CurHealth += Health / 3;
            if (CurHealth > Health)
            {
                CurHealth = Health;
            }

            CurHeal++;
            return true;
        }

        public void AddExperience(int exp)
        {
            Experience += exp;
        }

        public void LevelUp()
        {
            Level++;
            CurHealth = Health;
            Experience -= ExperienceToNextLevel;
            ExperienceToNextLevel = (int)(ExperienceToNextLevel * 1.5);
        }

        public void IncreaseHealth()
        {
            CurHealth += 20;
            CurHealth = Health;
        }

        public void IncreaseAttack()
        {
            AttackPower += 5;
        }

        public void IncreaseCriticalChance()
        {
            CriticalChance += 0.05f;
        }

        public void AddEnemyDefeated()
        {
            EnemysDefeated++;
        }

        public override string ToString()
        {
            return $"-----------Character-----------" +
                $"\n     Charcter name: {Name}" +
                $"\n     Level: {Level}" +
                $"\n     Health: {CurHealth}" +
                $"\n     Attack power: {AttackPower}";
        }
    }
}
