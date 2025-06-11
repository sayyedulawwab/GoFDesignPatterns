namespace Strategy.Bad;
public class PaymentService
{
    public void ProcessPayment(string provider, decimal amount)
    {
        if (provider == "Stripe")
        {
            Console.WriteLine($"Processing ${amount} via Stripe.");
            // Stripe logic
        }
        else if (provider == "PayPal")
        {
            Console.WriteLine($"Processing ${amount} via PayPal.");
            // PayPal logic
        }
        else if (provider == "BankTransfer")
        {
            Console.WriteLine($"Processing ${amount} via Bank Transfer.");
            // Bank transfer logic
        }
        else
        {
            throw new NotSupportedException("Unsupported provider.");
        }
    }
}
