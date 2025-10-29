namespace Patterns.Ex2
{
    internal class CoffeeMachine
    {
        public ICoffeeMachineState State;

        public CoffeeMachine(ICoffeeMachineState coffeeMachineState)
        {
            State = coffeeMachineState;
        }

        public void IdleCustomer()
        {
            State.IdleCustomer(this);
        }

        public void InsertCoin()
        {
            State.InsertCoin(this);
        }

        public void SelectDrink()
        {
            State.SelectDrink(this);
        }

        public void DispenseDrink()
        {
            State.DispenseDrink(this);
        }
    }
}
