namespace Delegates_Events
{
    internal class Car : Vehicle
    {
        public Car(int worth, int engineVolume) : base(worth, engineVolume)
        {

        }
        public override string ToString()
        {
            return $"Автомобиль: Стоимость - {_worth}, налог - {TaxCalculator()}, объём двигателя - {_engineCapacity} см.куб";
        }
    }
}
