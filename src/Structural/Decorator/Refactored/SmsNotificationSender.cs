namespace Decorator.Refactored;
public class SmsNotificationSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}