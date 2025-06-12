namespace Proxy.Bad;
public interface IPaymentGateway
{
    void MakePayment(decimal amount);
}
