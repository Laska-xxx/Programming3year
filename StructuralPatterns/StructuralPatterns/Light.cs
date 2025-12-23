namespace StructuralPatterns
{
    internal class Light
    {
        public bool IsTurnedOn { get; private set; }
        public float Brightness { get; private set; }
        public string Color { get; private set; }

        public void SwitchLight( bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
        }

        public void ChangeBrightness(float value)
        {
            Brightness = value;
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"---Light-----------\n{(IsTurnedOn ? "Turned on" : "Turned off")}, Brightness: {Brightness}, Color: {Color}";
        }
    }
}
/*
1. Light- класс, который отвечает за управление освещением в доме. Свойства: IsTurnedOn, Brightness, Color. 
    Методы: "SwitchLight"(включает-выключает свет),"ChangeBrightness" (Меняет силу свечения),  
    "ChangeColor" (Меняет цвет свечения), "ToString" (Выводит все свойства)
*/