namespace Delegates_Events
{
    internal class CountryHouse : Immovable
    {
        public CountryHouse(int worth, int area) : base(worth, area)
        {

        }

        public override string ToString()
        {
            return $"Дача: Стоимость - {_worth}, налог - {TaxCalculator()}, площадь - {_area} кв.м";
        }
    }
}
