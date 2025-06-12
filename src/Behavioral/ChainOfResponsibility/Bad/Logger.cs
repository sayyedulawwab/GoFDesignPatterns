namespace ChainOfResponsibility.Bad;
public class Logger
{
    public void Log(HttpRequest request)
    {
        Console.WriteLine($"Logged in user: {request.Username}");
    }
}
