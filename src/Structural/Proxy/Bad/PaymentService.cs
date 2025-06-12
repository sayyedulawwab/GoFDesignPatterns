namespace Proxy.Bad;
public class PaymentService
{
    private readonly IPaymentGateway _gateway = new RealPaymentGateway();
    private DateTime _lastPaymentTime;

    public void Pay(decimal amount)
    {
        if ((DateTime.Now - _lastPaymentTime).TotalSeconds < 5)
        {
            Console.WriteLine("[Error] Too many requests. Please wait.");
            return;
        }

        _gateway.MakePayment(amount);
        _lastPaymentTime = DateTime.Now;
    }
}
