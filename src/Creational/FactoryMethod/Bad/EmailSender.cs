namespace FactoryMethod.Bad;
public class EmailSender : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[Email] Sent to {to}: {message}");
    }
}
