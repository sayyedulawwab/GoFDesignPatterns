namespace Observer.Refactored;
public class EmailNotifier : IObserver
{
    public void Update(OrderPlacedEvent orderEvent)
    {
        Console.WriteLine($"[EmailNotifier] Sending email to {orderEvent.CustomerEmail}");
    }
}
