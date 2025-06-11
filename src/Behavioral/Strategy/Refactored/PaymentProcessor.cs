namespace Strategy.Refactored;
public class PaymentProcessor
{
    private readonly IPaymentStrategy _strategy;

    public PaymentProcessor(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Process(decimal amount)
    {
        _strategy.ProcessPayment(amount);
    }
}
