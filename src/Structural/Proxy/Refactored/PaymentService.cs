namespace Proxy.Refactored;
public class PaymentService
{
    private readonly IPaymentGateway _gateway;

    public PaymentService(IPaymentGateway gateway)
    {
        _gateway = gateway;
    }

    public void Pay(decimal amount)
    {
        _gateway.MakePayment(amount);
    }
}
