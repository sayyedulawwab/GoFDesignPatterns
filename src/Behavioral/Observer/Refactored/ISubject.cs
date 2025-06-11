namespace Observer.Refactored;
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(OrderPlacedEvent orderEvent);
}
