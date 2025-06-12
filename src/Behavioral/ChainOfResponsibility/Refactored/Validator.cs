namespace ChainOfResponsibility.Refactored;
public class Validator : Middleware
{
    protected override bool Check(HttpRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
        {
            Console.WriteLine("Validation failed.");
            return false;
        }

        Console.WriteLine("Validation passed.");
        return true;
    }
}
