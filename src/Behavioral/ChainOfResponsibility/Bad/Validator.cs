namespace ChainOfResponsibility.Bad;
public class Validator
{
    public void Validate(HttpRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            Console.WriteLine("Validation failed.");
        else
            Console.WriteLine("Validation passed.");
    }
}
