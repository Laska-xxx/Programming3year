namespace Patterns.Ex4
{
    internal class DessertDecorator : OrderDecorator
    {
        private int _dessertPrice;

        public DessertDecorator(IOrder order, int dessertPrice) : base(order)
        {
            _dessertPrice = dessertPrice;
        }

        public override int GetPrice()
        {
            return base.GetPrice() + _dessertPrice;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $" + Десерт (+{_dessertPrice})";
        }
    }
}
