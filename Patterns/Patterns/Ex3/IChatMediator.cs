namespace Patterns.Ex3
{
    internal interface IChatMediator
    {
        void Register(IChatMember member);
        void SendMessage(string message, IChatMember sender);
    }
}
/*   Разработайте систему управления чатом с использованием.  

   - У вас есть интерфейс IChatMediator для регистрации участников и отправки сообщений.  

   - Каждый участник чата реализует интерфейс IChatMember и может отправлять/получать сообщения.  

   - Посредник должен координировать отправку сообщения: 
        сообщение должно быть отправлено от одного участника всем остальным.  */