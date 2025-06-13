namespace Mediator.Bad;
public class NotificationService
{
    public void SendWelcomeEmail(string username)
    {
        Console.WriteLine($"Email sent to {username}");
    }
}
