namespace Patterns.Ex2
{
    internal interface ICoffeeMachineState
    {
        void InsertCoin(CoffeeMachine coffeeMachine);
        void SelectDrink(CoffeeMachine coffeeMachine);
        void DispenseDrink(CoffeeMachine coffeeMachine);
        void IdleCustomer(CoffeeMachine coffeeMachine);
    }
}
/*Создайте модель работы кофейного автомата.  

   - Автомат должен переходить между состояниями: 
        "Ожидание монеты" → "Выбор напитка" → "Выдача напитка" → "Готов".

   - Каждое состояние должно быть реализовано в отдельном классе, реализующем общий интерфейс ICoffeeMachineState.  

   - Автомат принимает запросы от пользователя 
        (например, InsertCoin(), SelectDrink(), DispenseDrink()), 
        но делегирует реализацию этим действиям состоянию.  

   В консольном приложении должен быть такой вывод  

   Пользователь → Внесение монет → Выбор напитка → Автомат выдаёт напиток → Автомат возвращается в состояние ожидания следующего клиента.*/