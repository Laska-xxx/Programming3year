namespace Patterns.Ex4
{
    internal class ExpressDeliveryDecorator : OrderDecorator
    {
        private int _expressDeliveryPrice;

        public ExpressDeliveryDecorator(IOrder order, int expressDeliveryPrice) : base(order)
        {
            _expressDeliveryPrice = expressDeliveryPrice;
        }

        public override int GetPrice()
        {
            return base.GetPrice() + _expressDeliveryPrice;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $" + Оперативная доставка (+{_expressDeliveryPrice})";
        }
    }
}
