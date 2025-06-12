namespace Proxy.Refactored;
public class RateLimitingProxy : IPaymentGateway
{
    private readonly IPaymentGateway _realGateway;
    private DateTime _lastPaymentTime;

    public RateLimitingProxy(IPaymentGateway realGateway)
    {
        _realGateway = realGateway;
    }

    public void MakePayment(decimal amount)
    {
        if ((DateTime.Now - _lastPaymentTime).TotalSeconds < 5)
        {
            Console.WriteLine("[RateLimiter] Too many requests. Try again later.");
            return;
        }

        _realGateway.MakePayment(amount);
        _lastPaymentTime = DateTime.Now;
    }
}
