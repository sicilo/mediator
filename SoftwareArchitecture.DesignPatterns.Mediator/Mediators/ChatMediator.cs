namespace SoftwareArchitecture.DesignPatterns.Mediator.Mediators
{
    using SoftwareArchitecture.DesignPatterns.Mediator.Colleagues;
    using SoftwareArchitecture.DesignPatterns.Mediator.Enums;
    using SoftwareArchitecture.DesignPatterns.Mediator.Mediators.Interfaces;
    using SoftwareArchitecture.DesignPatterns.Mediator.Models;

    public class ChatMediator : IChatMediator
    {
        private readonly List<ChatUserCollegue> _users = new();

        public List<KeyValuePair<int, MessageModel>> Messages { get; set; } = new();

        public void Notify(ChatUserCollegue user, UserColleagueActions action, int userId, MessageModel message)
        {
            if (action is UserColleagueActions.SendMessage)
            {
                ChatUserCollegue? recipient = _users.Find(u => u.Id == userId);

                recipient?.ReceiveMessage(message, user);
            }

            if (action is UserColleagueActions.ReceiveMessage)
            {
                ChatUserCollegue? sender = _users.Find(u => u.Id == userId);

                if(sender is not null )
                {
                    Messages.Add(new KeyValuePair<int, MessageModel>(sender.Id, message));
                }
            }
        }

        public ChatUserCollegue CreateUser(string name)
        {
            ChatUserCollegue newUser = new(this)
            {
                Id = _users.Count,
                Name = name,
            };

            _users.Add(newUser);

            return newUser;
        }

        public void ShowAllUsers()
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"User Id: {user.Id}, User Name: {user.Name}");
            }
        }
    }
}
