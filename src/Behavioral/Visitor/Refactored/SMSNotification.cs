namespace Visitor.Refactored;
public class SMSNotification : INotification
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    public void Accept(INotificationVisitor visitor) => visitor.Visit(this);
}
