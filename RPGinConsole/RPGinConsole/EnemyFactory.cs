using RPGinConsole;
using System;

namespace RPGinConsole
{
    internal class EnemyFactory
    {
        private Random _random = new Random();
        private List<string> _enemyTypes = new List<string> { "Bee", "Wolf", "Bear", "Spider" };

        public Enemy CreateMonster()
        {
            string name = _enemyTypes[_random.Next(_enemyTypes.Count)];
            int level = _random.Next(1, 6);
            int health = _random.Next(20, 50) + level * 5;
            int attack = _random.Next(5, 15) + level * 2;
            int exp = _random.Next(20, 50) * level;

            return new Enemy(name, health, attack, level, exp);
        }
    }
}
