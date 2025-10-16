namespace Delegates_Events
{
    abstract class Immovable : Property
    {
        protected int _area { get; set; }

        public Immovable(int worth, int area) : base(worth)
        {
            _area = area;
        }

        public double CostPerSquareMeter()
        {
            return _worth / _area;
        }

        public override double TaxCalculator()
        {
            if (_area < 100)
                return _worth / 500;
            else if (_area >= 100 && _area <= 300)
                return _worth / 350;
            else
                return _worth / 250;
        }
    }
}
