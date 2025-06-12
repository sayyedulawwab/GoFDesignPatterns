namespace Adapter.Refactored;
public class StripeAdapter : IPaymentGateway
{
    private readonly StripeSdk _stripeSdk;

    public StripeAdapter(StripeSdk stripeSdk)
    {
        _stripeSdk = stripeSdk;
    }

    public void ProcessPayment(decimal amount)
    {
        _stripeSdk.MakeStripePayment(amount); // adapting interface
    }
}
