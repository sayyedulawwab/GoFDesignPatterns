namespace FactoryMethod.Refactored;
public class PushSender : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[Push] Sent to {to}: {message}");
    }
}