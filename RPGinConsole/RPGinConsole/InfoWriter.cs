namespace RPGinConsole
{
    internal class InfoWriter
    {
        public string StatsInfo(Player player)
        {
            return $"--------Character Stats--------" +
                $"\n     Level: {player.Level}" +
                $"\n     Exp: {player.Experience}/{player.ExperienceToNextLevel}" +
                $"\n     Health: {player.CurHealth}/{player.Health}" +
                $"\n     Attack power: {player.AttackPower}" +
                $"\n     Crit chance: {player.CriticalChance:P1}" +
                $"\n     Enemys defeated: {player.EnemysDefeated}";
        }

        public string GameEndInfo(Player player)
        {
            return $"Charcter name: {player.Name}" +
                $"\n    Class: {player.Class}" +
                $"\n    Level: {player.Level}" +
                $"\n    Enemys defeated: {player.EnemysDefeated}";
        }
    }
}
