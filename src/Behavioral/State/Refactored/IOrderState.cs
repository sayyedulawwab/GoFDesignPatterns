namespace State.Refactored;
public interface IOrderState
{
    void Next(OrderContext context);
}
