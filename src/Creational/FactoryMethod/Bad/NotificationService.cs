namespace FactoryMethod.Bad;
public class NotificationService
{
    public void Send(string type, string to, string message)
    {
        INotificationSender sender;

        if (type == "Email")
            sender = new EmailSender();
        else if (type == "SMS")
            sender = new SmsSender();
        else if (type == "Push")
            sender = new PushSender();
        else
            throw new Exception("Unsupported notification type");

        sender.Send(to, message);
    }
}
