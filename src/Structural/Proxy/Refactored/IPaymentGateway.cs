namespace Proxy.Refactored;
public interface IPaymentGateway
{
    void MakePayment(decimal amount);
}
