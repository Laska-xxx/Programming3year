namespace StructuralPatterns
{
    internal class AirConditioner
    {
        public bool IsTurnedOn { get; private set; }
        public float Temperature { get; private set; }

        public void Switch(bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
        }

        public void SetTemperature(float value)
        {
            Temperature = value;
        }

        public override string ToString()
        {
            return $"---Air Conditioner-----------\n{(IsTurnedOn ? "Turned on" : "Turned off")}, Temperature: {Temperature}";
        }
    }
}
/*
3. AirConditioner - класс, управляющий кондиционером в доме. Свойства: IsTurnedOn, Temperature. 
    Методы: "Switch"(включает-выключает кондей), "SetTemperature" (Задаёт температуру воздуха), 
    "ToString" (Выводит все свойства).
 */