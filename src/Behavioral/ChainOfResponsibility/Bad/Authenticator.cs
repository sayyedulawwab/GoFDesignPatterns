namespace ChainOfResponsibility.Bad;
public class Authenticator
{
    public void Authenticate(HttpRequest request)
    {
        if (request.Username == "admin" && request.Password == "1234")
            Console.WriteLine("Authentication successful.");
        else
            Console.WriteLine("Authentication failed.");
    }
}
