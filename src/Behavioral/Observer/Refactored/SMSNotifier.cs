namespace Observer.Refactored;
public class SMSNotifier : IObserver
{
    public void Update(OrderPlacedEvent orderEvent)
    {
        Console.WriteLine($"[SMSNotifier] Sending SMS to {orderEvent.PhoneNumber}");
    }
}
