namespace Delegates_Events
{
    abstract class Vehicle : Property
    {
        public double _engineCapacity;

        public Vehicle(int worth, int engineCapacity) : base(worth)
        {
            _engineCapacity = engineCapacity;
        }

        public override double TaxCalculator()
        {
            return _worth * _engineCapacity / 3000;
        }
    }
}
