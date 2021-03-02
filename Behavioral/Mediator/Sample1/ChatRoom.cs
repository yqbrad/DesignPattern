using System;

namespace Mediator.Sample1
{
    public class ChatRoom: IChatRoom
    {
        public void ShowMessage(User user, string message)
            => Console.WriteLine($"{DateTime.Now:D} [{user.GetName()}]: {message}");
    }
}