namespace Mediator.Refactored;
public class AuditService : IService
{
    public void SetMediator(IMediator mediator) { }

    public void Record(string action, string user)
    {
        Console.WriteLine($"[AUDIT] {action} by {user}");
    }
}
