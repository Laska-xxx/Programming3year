namespace Patterns.Ex3
{
    internal class ChatMediator : IChatMediator
    {
        private List<IChatMember> _members = new List<IChatMember>();
        
        public void Register(IChatMember member)
        {
            _members.Add(member);
        }

        public void SendMessage(string message, IChatMember sender)
        {
            foreach (var member in _members)
            {
                if (member != sender)
                {
                    member.Receive(message);
                }
            }
        }
    }
}
