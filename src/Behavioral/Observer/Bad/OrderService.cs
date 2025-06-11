namespace Observer.Bad;
public class OrderService
{
    public void PlaceOrder(string customerEmail, string phoneNumber)
    {
        Console.WriteLine("Order placed successfully.");

        // Tightly coupled notifications
        Console.WriteLine($"Sending email to {customerEmail}");
        Console.WriteLine($"Sending SMS to {phoneNumber}");
    }
}
