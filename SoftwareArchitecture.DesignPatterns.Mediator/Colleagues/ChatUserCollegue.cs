namespace SoftwareArchitecture.DesignPatterns.Mediator.Colleagues
{
    using SoftwareArchitecture.DesignPatterns.Mediator.Enums;
    using SoftwareArchitecture.DesignPatterns.Mediator.Mediators.Interfaces;
    using SoftwareArchitecture.DesignPatterns.Mediator.Models;
    using System.Reflection;

    public class ChatUserCollegue
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        private readonly IChatMediator _chat;

        public ChatUserCollegue(IChatMediator chat)
        {
            _chat = chat;
        }

        public void SendMessage(string message, int to)
        {
            _chat.Notify(this, UserColleagueActions.SendMessage, to, new MessageModel
            {
                Message = message,
                Date = DateTime.Now,
            });
        }

        public void ReceiveMessage(MessageModel message, ChatUserCollegue from)
        {
            Console.WriteLine($"[Message sent at {message.Date} by {from.Name} to {Name}]: {message.Message}");
            _chat.Notify(this, UserColleagueActions.ReceiveMessage, from.Id, message);
        }
    }
}
