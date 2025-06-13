namespace Visitor.Refactored;
public class AuditingVisitor : INotificationVisitor
{
    public void Visit(EmailNotification email)
    {
        Console.WriteLine($"Auditing Email: {email.Email}");
    }

    public void Visit(SMSNotification sms)
    {
        Console.WriteLine($"Auditing SMS: {sms.PhoneNumber}");
    }

    public void Visit(PushNotification push)
    {
        Console.WriteLine($"Auditing Push: {push.DeviceId}");
    }
}
