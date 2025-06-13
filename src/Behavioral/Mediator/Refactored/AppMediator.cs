namespace Mediator.Refactored;
public class AppMediator : IMediator
{
    private readonly NotificationService _notification;
    private readonly LoggingService _logger;
    private readonly AuditService _auditor;

    public AppMediator(NotificationService notification, LoggingService logger, AuditService auditor)
    {
        _notification = notification;
        _logger = logger;
        _auditor = auditor;
    }

    public void Notify(object sender, string action, string username)
    {
        if (action == "UserCreated")
        {
            _logger.Log($"User '{username}' created.");
            _notification.SendWelcomeEmail(username);
            _auditor.Record("CreateUser", username);
        }
    }
}
