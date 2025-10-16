namespace Delegates_Events
{
    abstract class Property
    {
        protected int _worth;
        public Property(int worth)
        {
            _worth = worth;
        }
        public abstract double TaxCalculator();
        public abstract override string ToString();
    }
}
