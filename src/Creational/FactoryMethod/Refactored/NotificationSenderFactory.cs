namespace FactoryMethod.Refactored;
public class NotificationSenderFactory
{
    public static INotificationSender Create(string type)
    {
        return type switch
        {
            "Email" => new EmailSender(),
            "SMS" => new SmsSender(),
            "Push" => new PushSender(),
            _ => throw new ArgumentException("Invalid type")
        };
    }
}
