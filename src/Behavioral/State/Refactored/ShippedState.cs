namespace State.Refactored;
public class ShippedState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Delivering order...");
        context.SetState(new DeliveredState());
    }
}
