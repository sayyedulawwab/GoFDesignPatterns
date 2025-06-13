namespace Visitor.Refactored;
public class PushNotification : INotification
{
    public string DeviceId { get; set; }
    public string Message { get; set; }

    public void Accept(INotificationVisitor visitor) => visitor.Visit(this);
}
