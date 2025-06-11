namespace Observer.Refactored;
public class OrderService
{
    private readonly List<IObserver> _observers = new();

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);

    public void Notify(OrderPlacedEvent orderEvent)
    {
        foreach (var observer in _observers)
        {
            observer.Update(orderEvent);
        }
    }

    public void PlaceOrder(string email, string phone)
    {
        Console.WriteLine("Order placed successfully.");

        var orderEvent = new OrderPlacedEvent(email, phone);
        Notify(orderEvent);
    }
}
