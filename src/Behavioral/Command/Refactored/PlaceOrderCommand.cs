namespace Command.Refactored;
public class PlaceOrderCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Placing Order...");
    }
}
