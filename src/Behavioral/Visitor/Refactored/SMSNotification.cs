namespace Visitor.Refactored;
public class SMSNotification : INotification
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }

    public void Accept(INotificationVisitor visitor) => visitor.Visit(this);
}
