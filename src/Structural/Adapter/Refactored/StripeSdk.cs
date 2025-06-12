namespace Adapter.Refactored;
public class StripeSdk
{
    public void MakeStripePayment(decimal amount)
    {
        Console.WriteLine($"[StripeSdk] Paid ${amount} using Stripe SDK.");
    }
}
