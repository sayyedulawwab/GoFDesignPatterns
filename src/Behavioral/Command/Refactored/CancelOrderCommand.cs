namespace Command.Refactored;
public class CancelOrderCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Cancelling Order...");
    }
}
