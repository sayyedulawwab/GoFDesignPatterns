namespace Visitor.Refactored;
public class PushNotification : INotification
{
    public string DeviceId { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    public void Accept(INotificationVisitor visitor) => visitor.Visit(this);
}
