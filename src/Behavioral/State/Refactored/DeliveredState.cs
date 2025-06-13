namespace State.Refactored;
public class DeliveredState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Order is already delivered.");
    }
}
