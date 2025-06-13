namespace Bridge.Bad;
public class Logger
{
    public void LogErrorToConsole(string message)
    {
        Console.WriteLine($"[Console] ERROR: {message}");
    }

    public void LogErrorToFile(string message)
    {
        Console.WriteLine($"[File] ERROR: {message}");
    }

    public void LogInfoToConsole(string message)
    {
        Console.WriteLine($"[Console] INFO: {message}");
    }

    public void LogInfoToFile(string message)
    {
        Console.WriteLine($"[File] INFO: {message}");
    }
}
