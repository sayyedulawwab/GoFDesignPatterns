namespace Visitor.Refactored;
public interface INotification
{
    void Accept(INotificationVisitor visitor);
}
