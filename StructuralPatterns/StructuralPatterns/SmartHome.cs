namespace StructuralPatterns
{
    internal class SmartHome
    {
        private Light _light;
        private TV _tv;
        private AirConditioner _airConditioner;
        private MusicStation _musicStation;

        public SmartHome()
        {
            _light = new Light();
            _tv = new TV();
            _airConditioner = new AirConditioner();
            _musicStation = new MusicStation();
        }

        public void SetUpHome(string mode)
        {
            switch (mode)
            {
                case "Night":
                    SetUpNightMode();
                    break;
                case "Morning":
                    SetUpMorningMode();
                    break;
                case "Chill":
                    SetUpHomeAloneMode();
                    break;
                default:
                    SetUpDefaultMode();
                    break;
            }

            ShowGadgetsInfo();
        }

        private void SetUpDefaultMode()
        {
            LightController(true);
            TvController();
            AirConditionerController(true);
            MusicStationController(true, "classical music");

            Console.WriteLine("Set up default mode");
        }

        private void SetUpNightMode()
        {
            LightController();
            TvController();
            AirConditionerController(true, 21);
            MusicStationController(true, "sounds of nature");

            Console.WriteLine("Set up night mode");
        }

        private void SetUpMorningMode()
        {
            LightController(true, 1, "warm white");
            TvController(true, "Yoga");
            AirConditionerController(true, 18);
            MusicStationController(true, "Maraby");

            Console.WriteLine("Set up morning mode");
        }

        private void SetUpHomeAloneMode()
        {
            LightController(true, 0.3f, "violet");
            TvController(true, "HomeAlone");
            AirConditionerController();
            MusicStationController();
            Console.WriteLine("Set up chill mode");
        }

        private void LightController(bool isTurnedOn = false, float brightnessValue = 0.5f, string color = "soft white")
        {
            _light.SwitchLight(isTurnedOn);
            _light.ChangeBrightness(brightnessValue);
            _light.ChangeColor(color);
        }

        private void TvController(bool isTurnedOn = false, string program = "nothing")
        {
            _tv.SwitchTV(isTurnedOn);
            _tv.TurnOnProgram(program);
        }

        private void AirConditionerController(bool isturnedOn = false, float tempValue = 22)
        {
            _airConditioner.Switch(isturnedOn);
            _airConditioner.SetTemperature(tempValue);
        }

        private void MusicStationController(bool isTurnedOn = false, string music = "nothing")
        {
            _musicStation.Switch(isTurnedOn);
            _musicStation.ChangeMusic(music);
        }

        private void ShowGadgetsInfo()
        {
            Console.WriteLine(_light.ToString());
            Console.WriteLine(_tv.ToString());
            Console.WriteLine(_airConditioner.ToString());
            Console.WriteLine(_musicStation.ToString());
        }
    }
}
/*
 Создайте класс "SmartHome", который будет реализовывать паттерн проектирования фасада и содержать следующие классы:

Создайте метод "SetUpHome", в котором вы будете использовать классы "Light", "TV ", "AirConditioner " и 
    "MusicStation" для настройки умного дома. В конце вызова метода вывести ToString каждого класса в консоль.

Например, если пользователь хочет настроить умный дом на режим "Ночной", то он может вызвать метод 
    "SetUpHome" с параметром "Ночной". В этом случае, метод будет вызывать соответствующие методы классов 
    "Свет"(выключает свет), "Телевизор"(выключает телик) и "Кондиционер"(включается и ставит температуру на 20), 
    чтобы установить соответствующий режим работы. 

Также, в методе "SetUpHome" можно использовать класс "Колонка"(включает Lofi Hip Hop).
    Таким образом реализовать несколько режимов для умного дома. Например: "Вечеринка", "Доброе утро", 
    "Собираюсь на пары", "Ухожу", "Один дома".
 */