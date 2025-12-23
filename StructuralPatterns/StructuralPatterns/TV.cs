namespace StructuralPatterns
{
    internal class TV
    {
        public bool IsTurnedOn { get; private set; }
        public string Program { get; private set; }

        public void SwitchTV(bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
        }

        public void TurnOnProgram(string program)
        {
            Program = program;
        }

        public override string ToString()
        {
            return $"---TV-----------\n{(IsTurnedOn ? "Turned on" : "Turned off")}, Program: {Program}";
        }
    }
}
/*
2. TV - класс, отвечающий за управление телевизором. Свойства: IsTurnedOn, Program. 
    Методы: "SwitchTV"(включает-выключает телик),"TurnOnProgram" (Включает какое-то приложение), 
    "ToString" (Выводит все свойства)
 */