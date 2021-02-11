using System;

namespace Mediator
{
    public class ChatRoom: IChatRoom
    {
        public void ShowMessage(User user, string message)
            => Console.WriteLine($"{DateTime.Now:D} [{user.GetName()}]: {message}");
    }
}