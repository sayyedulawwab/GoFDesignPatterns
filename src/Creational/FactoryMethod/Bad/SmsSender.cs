namespace FactoryMethod.Bad;
public class SmsSender : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[SMS] Sent to {to}: {message}");
    }
}
