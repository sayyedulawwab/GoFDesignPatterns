namespace FactoryMethod.Refactored;
public class NotificationService
{
    public void Send(string type, string to, string message)
    {
        var sender = NotificationSenderFactory.Create(type);
        sender.Send(to, message);
    }
}
