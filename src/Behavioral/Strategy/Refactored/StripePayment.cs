namespace Strategy.Refactored;
public class StripePayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount} via Stripe.");
        // Stripe logic
    }
}
