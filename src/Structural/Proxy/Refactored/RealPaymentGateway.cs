namespace Proxy.Refactored;
public class RealPaymentGateway : IPaymentGateway
{
    public void MakePayment(decimal amount)
    {
        Console.WriteLine($"[Payment] Processed payment of ${amount}");
    }
}
