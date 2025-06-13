namespace Mediator.Bad;
public class AuditService
{
    public void Record(string action, string user)
    {
        Console.WriteLine($"[AUDIT] {action} by {user}");
    }
}
