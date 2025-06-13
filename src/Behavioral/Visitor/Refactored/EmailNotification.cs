namespace Visitor.Refactored;
public class EmailNotification : INotification
{
    public string Email { get; set; }
    public string Message { get; set; }

    public void Accept(INotificationVisitor visitor) => visitor.Visit(this);
}
