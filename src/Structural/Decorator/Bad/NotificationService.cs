namespace Decorator.Bad;
public class NotificationService
{
    public void Send(string type, string message)
    {
        Console.WriteLine("Validating notification");

        Console.WriteLine($"[LOG] Sending {type} notification...");

        if (type == "Email")
        {
            Console.WriteLine($"Sending EMAIL: {message}");
        }
        else if (type == "SMS")
        {
            Console.WriteLine($"Sending SMS: {message}");
        }

        Console.WriteLine("[LOG] Notification sent.");
    }
}
