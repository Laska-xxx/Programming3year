namespace StructuralPatterns
{
    internal class MusicStation
    {
        public bool IsTurnedOn { get; private set; }
        public string Music { get; private set; }

        public void Switch(bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
        }

        public void ChangeMusic(string music)
        {
            if (!IsTurnedOn)
            {
                Switch(true);
            }

            Music = music;
        }

        public override string ToString()
        {
            return $"---Music Station-----------\n{(IsTurnedOn ? "Turned on" : "Turned off")}, Music: {Music}";
        }
    }
}
/*
4. MusicStation - класс, управляющий колонкой в доме. Свойства: IsTurnedOn, Music. 
    Методы: "Switch"(включает-выключает колонку), "SetMusic" (Включает какую-то музыку), 
    "ToString" (Выводит все свойства).
*/