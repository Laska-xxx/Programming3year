namespace Patterns.Ex2
{
    internal class WaitingCoinState : ICoffeeMachineState
    {
        public void IdleCustomer(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Автомат ожидает внесения монет");
        }

        public void InsertCoin(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("В автоман внесли деньги");
            coffeeMachine.State = new DrinkSelectionState();
        }
        public void SelectDrink(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Перед выбором напитка внесите деньи");
        }

        public void DispenseDrink(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Перед получением напитка внесите деньги и выберете напиток");
        }
    }
}
