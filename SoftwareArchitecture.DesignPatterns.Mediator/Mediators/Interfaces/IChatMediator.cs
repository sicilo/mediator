namespace SoftwareArchitecture.DesignPatterns.Mediator.Mediators.Interfaces
{
    using SoftwareArchitecture.DesignPatterns.Mediator.Colleagues;
    using SoftwareArchitecture.DesignPatterns.Mediator.Enums;
    using SoftwareArchitecture.DesignPatterns.Mediator.Models;

    public interface IChatMediator
    {
        public void Notify(ChatUserCollegue user, UserColleagueActions action, int userId, MessageModel message);

        public ChatUserCollegue CreateUser(string name);

        public void ShowAllUsers();
    }
}
