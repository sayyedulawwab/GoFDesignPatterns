namespace Mediator.Bad;
public class LoggingService
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
