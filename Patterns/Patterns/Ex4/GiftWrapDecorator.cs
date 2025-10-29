namespace Patterns.Ex4
{
    internal class GiftWrapDecorator : OrderDecorator
    {
        private int _giftWrapPrice;
        public GiftWrapDecorator(IOrder order, int giftWrapPrice) : base(order)
        {
            _giftWrapPrice = giftWrapPrice;
        }

        public override int GetPrice()
        {
            return base.GetPrice() + _giftWrapPrice;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $" + Упаковка подарков (+{_giftWrapPrice})";
        }
    }
}
