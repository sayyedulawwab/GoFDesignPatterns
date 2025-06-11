namespace Decorator.Refactored;
public class ValidatingNotificationSenderDecorator : INotificationSender
{
    private readonly INotificationSender _inner;

    public ValidatingNotificationSenderDecorator(INotificationSender inner)
    {
        _inner = inner;
    }

    public void Send(string message)
    {
        Console.WriteLine("Validating notification");

        _inner.Send(message);
    }
}
