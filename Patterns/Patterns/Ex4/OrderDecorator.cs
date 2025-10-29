namespace Patterns.Ex4
{
    abstract class OrderDecorator : IOrder
    {
        private IOrder _order;

        protected OrderDecorator(IOrder order)
        {
            _order = order;
        }

        public virtual int GetPrice()
        {
            return _order.GetPrice();
        }

        public virtual string GetDescription()
        {
            return _order.GetDescription();
        }

        
    }
}
