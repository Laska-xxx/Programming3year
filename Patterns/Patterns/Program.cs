using Patterns.Ex1;
using Patterns.Ex2;
using Patterns.Ex3;
using Patterns.Ex4;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();

            void Ex1()
            {
                Console.WriteLine("-------------- Exercise 1 --------------");

                IFigure _figure = new Cube(5, 5, 5);
                IFigure _figure1 = _figure.Clone();

                Console.WriteLine(_figure.ToString());
                Console.WriteLine(_figure1.ToString());

                _figure1 = new Sphere(10);

                Console.WriteLine(_figure.ToString());
                Console.WriteLine(_figure1.ToString());
            }

            void Ex2()
            {
                Console.WriteLine("-------------- Exercise 2 --------------");

                CoffeeMachine coffeeMachine = new CoffeeMachine(new IdleState());

                coffeeMachine.IdleCustomer();
                coffeeMachine.InsertCoin();
                coffeeMachine.SelectDrink();

                coffeeMachine.SelectDrink();

                coffeeMachine.DispenseDrink();
            }

            void Ex3()
            {
                Console.WriteLine("-------------- Exercise 3 --------------");

                ChatMediator mediator = new ChatMediator();

                ChatMember member = new ChatMember(mediator);
                ChatMember member1 = new ChatMember(mediator);
                ChatMember member2 = new ChatMember(mediator);

                mediator.Register(member);
                mediator.Register(member1);
                mediator.Register(member2);

                member.Send($"Мембер отправил сообщение");
                member2.Send($"Мембер2 отправил сообщение");
            }

            void Ex4()
            {
                Console.WriteLine("-------------- Exercise 4 --------------");

                IOrder order = new BaseOrder(100, "Роллы");

                Console.WriteLine(order.GetDescription());
                Console.WriteLine("Итог: " + order.GetPrice());

                order = new GiftWrapDecorator(order, 15);
                order = new DessertDecorator(order, 10);

                Console.WriteLine(order.GetDescription());
                Console.WriteLine("Итог: " + order.GetPrice());
            }

            void Ex5()
            {
                Console.WriteLine("-------------- Exercise 5 --------------");
            }
        }
    }
}
