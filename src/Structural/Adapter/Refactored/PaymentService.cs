namespace Adapter.Refactored;
public class PaymentService
{
    private readonly IPaymentGateway _paymentGateway;

    public PaymentService(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public void Pay(decimal amount)
    {
        _paymentGateway.ProcessPayment(amount);
    }
}
