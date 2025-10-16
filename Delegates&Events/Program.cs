namespace Delegates_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Property[] properties = new Property[10];
            properties[0] = new Appartment(11000000, 150);
            properties[1] = new Appartment(6000000, 90);
            properties[2] = new Appartment(1500000, 26);
            properties[3] = new Car(15000000, 300);
            properties[4] = new Car(7000000, 150);
            properties[5] = new Car(3000000, 100);
            properties[6] = new Boat(5000000, 150);
            properties[7] = new Boat(900000, 70);
            properties[7] = new CountryHouse(9000000, 200);
            properties[7] = new CountryHouse(13000000, 350);

            foreach (var property in properties)
            {
                Console.WriteLine(property);
            }
        }
    }
}

/*В функции main завести массив из 10 указателей на Property и заполнить его указателями на динамические объекты производных классов 
    (3 — Appartment, 3 — Car, 2 — Boat,  2 — CountryHouse).*/