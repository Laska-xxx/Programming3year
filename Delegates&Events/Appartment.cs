namespace Delegates_Events
{
    internal class Appartment : Immovable
    {
        public Appartment(int worth, int area) : base(worth, area)
        {

        }

        public override string ToString()
        {
            return $"Квартира: Стоимость - {_worth}, налог - {TaxCalculator()}, площадь - {_area} кв.м";
        }
    }
}
