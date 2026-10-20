namespace Visitor.Refactored;
public class EmailNotification : INotification
{
    public string Email { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    public void Accept(INotificationVisitor visitor) => visitor.Visit(this);
}
