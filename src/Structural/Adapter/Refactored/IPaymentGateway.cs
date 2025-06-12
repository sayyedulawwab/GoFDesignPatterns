namespace Adapter.Refactored;
public interface IPaymentGateway
{
    void ProcessPayment(decimal amount);
}
