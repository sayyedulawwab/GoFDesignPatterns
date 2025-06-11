namespace Strategy.Refactored;
public class BankTransferPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount} via Bank Transfer.");
        // Bank transfer logic
    }
}
