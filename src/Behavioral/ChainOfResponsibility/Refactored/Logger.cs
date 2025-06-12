namespace ChainOfResponsibility.Refactored;
public class Logger : Middleware
{
    protected override bool Check(HttpRequest request)
    {
        Console.WriteLine($"Logged in user: {request.Username}");
        return true;
    }
}
