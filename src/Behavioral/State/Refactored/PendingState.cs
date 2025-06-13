namespace State.Refactored;
public class PendingState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Processing payment...");
        context.SetState(new PaidState());
    }
}
