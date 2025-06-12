namespace ChainOfResponsibility.Refactored;
public class Authenticator : Middleware
{
    protected override bool Check(HttpRequest request)
    {
        if (request.Username == "admin" && request.Password == "1234")
        {
            Console.WriteLine("Authentication successful.");
            return true;
        }

        Console.WriteLine("Authentication failed.");
        return false;
    }
}

