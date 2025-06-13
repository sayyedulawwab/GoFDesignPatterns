namespace Visitor.Refactored;
public class SendingVisitor : INotificationVisitor
{
    public void Visit(EmailNotification email)
    {
        Console.WriteLine($"Sending Email to {email.Email}: {email.Message}");
    }

    public void Visit(SMSNotification sms)
    {
        Console.WriteLine($"Sending SMS to {sms.PhoneNumber}: {sms.Message}");
    }

    public void Visit(PushNotification push)
    {
        Console.WriteLine($"Sending Push to {push.DeviceId}: {push.Message}");
    }
}
