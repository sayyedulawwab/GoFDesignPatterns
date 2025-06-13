namespace Mediator.Refactored;
public class LoggingService : IService
{
    public void SetMediator(IMediator mediator) { }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
