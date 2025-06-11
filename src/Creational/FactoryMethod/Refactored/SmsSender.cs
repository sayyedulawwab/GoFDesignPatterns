namespace FactoryMethod.Refactored;
public class SmsSender : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[SMS] Sent to {to}: {message}");
    }
}
