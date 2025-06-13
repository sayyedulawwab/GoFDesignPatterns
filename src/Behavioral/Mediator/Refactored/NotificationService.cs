namespace Mediator.Refactored;
public class NotificationService : IService
{
    public void SetMediator(IMediator mediator) { }

    public void SendWelcomeEmail(string username)
    {
        Console.WriteLine($"Email sent to {username}");
    }
}
