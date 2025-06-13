namespace Visitor.Refactored;
public interface INotificationVisitor
{
    void Visit(EmailNotification email);
    void Visit(SMSNotification sms);
    void Visit(PushNotification push);
}
