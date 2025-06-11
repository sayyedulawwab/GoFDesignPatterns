namespace Observer.Refactored;
public interface IObserver
{
    void Update(OrderPlacedEvent orderEvent);
}
