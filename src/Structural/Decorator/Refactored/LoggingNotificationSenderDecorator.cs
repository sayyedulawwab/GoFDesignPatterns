namespace Decorator.Refactored;
public class LoggingNotificationSenderDecorator : INotificationSender
{
    private readonly INotificationSender _inner;

    public LoggingNotificationSenderDecorator(INotificationSender inner)
    {
        _inner = inner;
    }

    public void Send(string message)
    {
        Console.WriteLine("[LOG] Sending notification...");

        _inner.Send(message);

        Console.WriteLine("[LOG] Notification sent.");
    }
}
