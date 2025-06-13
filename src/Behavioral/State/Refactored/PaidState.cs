namespace State.Refactored;
public class PaidState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Shipping order...");
        context.SetState(new ShippedState());
    }
}
