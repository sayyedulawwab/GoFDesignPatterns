namespace Decorator.Refactored;
public class EmailNotificationSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending EMAIL: {message}");
    }
}
