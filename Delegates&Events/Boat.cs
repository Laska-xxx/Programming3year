namespace Delegates_Events
{
    internal class Boat : Vehicle
    {
        public Boat(int worth, int engineVolume) : base(worth, engineVolume)
        {

        }
        public override string ToString()
        {
            return $"Лодка: Стоимость - {_worth}, налог - {TaxCalculator()}, объём двигателя - {_engineCapacity} см.куб";
        }
    }
}
