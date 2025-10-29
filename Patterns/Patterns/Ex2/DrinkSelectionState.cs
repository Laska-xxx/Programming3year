namespace Patterns.Ex2
{
    internal class DrinkSelectionState : ICoffeeMachineState
    {
        public void IdleCustomer(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Автомат уже обслуживает клиента");
        }
        public void InsertCoin(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("В автомат уже внесли деньги");
        }

        public void SelectDrink(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Напиток выбран");
            coffeeMachine.State = new DrinkDispensingState();
        }
        public void DispenseDrink(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Переж получением напитка выберете его");
        }
    }
}
