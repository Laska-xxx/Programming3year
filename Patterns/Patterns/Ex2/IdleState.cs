namespace Patterns.Ex2
{
    internal class IdleState : ICoffeeMachineState
    {
        public void IdleCustomer(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Автомат ожидает клиента");
            coffeeMachine.State = new WaitingCoinState();
        }

        public void InsertCoin(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Автомат еще не закончил работу");
        }

        public void SelectDrink(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Автомат еще не закончил работу");
        }

        public void DispenseDrink(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Автомат еще не закончил работу");
        }
    }
}
