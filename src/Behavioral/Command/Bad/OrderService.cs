namespace Command.Bad;
public class OrderService
{
    public void Execute(string action)
    {
        if (action == "PlaceOrder")
        {
            Console.WriteLine("Placing Order...");
        }
        else if (action == "CancelOrder")
        {
            Console.WriteLine("Cancelling Order...");
        }
    }
}
