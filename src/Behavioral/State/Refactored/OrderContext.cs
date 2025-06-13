namespace State.Refactored;
public class OrderContext
{
    private IOrderState _state;

    public OrderContext()
    {
        _state = new PendingState();
    }

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void Next()
    {
        _state.Next(this);
    }
}
