namespace Adapter.Bad;
public class PaymentService
{
    private readonly StripeSdk _stripeSdk = new();

    public void ProcessStripePayment(decimal amount)
    {
        _stripeSdk.MakeStripePayment(amount); // tightly coupled
    }
}
