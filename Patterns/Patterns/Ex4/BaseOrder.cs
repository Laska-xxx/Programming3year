namespace Patterns.Ex4
{
    internal class BaseOrder : IOrder
    {
        private int _price;
        private string _item;

        public BaseOrder(int price, string item)
        {
            _price = price;
            _item = item;
        }

        public int GetPrice()
        {
            return _price;
        }

        public string GetDescription()
        {
            return $"Базовый заказ: {_item}";
        }
    }
}
