namespace Strategy.Refactored;
public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount} via PayPal.");
        // PayPal logic
    }
}
