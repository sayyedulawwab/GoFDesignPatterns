namespace Strategy.Refactored;
public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}
