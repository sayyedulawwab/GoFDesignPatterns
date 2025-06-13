namespace Visitor.Refactored;
public class LoggingVisitor : INotificationVisitor
{
    public void Visit(EmailNotification email)
    {
        Console.WriteLine($"Logging Email to {email.Email}: {email.Message}");
    }

    public void Visit(SMSNotification sms)
    {
        Console.WriteLine($"Logging SMS to {sms.PhoneNumber}: {sms.Message}");
    }

    public void Visit(PushNotification push)
    {
        Console.WriteLine($"Logging Push to {push.DeviceId}: {push.Message}");
    }
}
