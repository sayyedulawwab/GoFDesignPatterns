namespace Mediator.Bad;
public class UserService
{
    private readonly NotificationService _notifier = new();
    private readonly LoggingService _logger = new();
    private readonly AuditService _auditor = new();

    public void CreateUser(string username)
    {
        Console.WriteLine($"User '{username}' created.");
        _logger.Log($"User '{username}' created.");
        _notifier.SendWelcomeEmail(username);
        _auditor.Record("CreateUser", username);
    }
}
