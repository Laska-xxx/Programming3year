namespace Patterns.Ex3
{
    internal class ChatMember : IChatMember
    {
        private IChatMediator _mediator;

        public ChatMember(IChatMediator mediator)
        {
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"Получил сообщение: {message}");
        }
    }
}
