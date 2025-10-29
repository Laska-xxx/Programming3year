namespace Patterns.Ex2
{
    internal class DrinkDispensingState : ICoffeeMachineState
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
            Console.WriteLine("Напиток уже выбран");
        }

        public void DispenseDrink(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Напиток выдан клиенту");
            coffeeMachine.State = new IdleState();
        }
    }
}
