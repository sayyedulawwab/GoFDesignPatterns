namespace State.Bad;
public enum OrderStatus
{
    Pending,
    Paid,
    Shipped,
    Delivered
}

public class Order
{
    public OrderStatus Status { get; private set; } = OrderStatus.Pending;

    public void Next()
    {
        switch (Status)
        {
            case OrderStatus.Pending:
                Console.WriteLine("Processing payment...");
                Status = OrderStatus.Paid;
                break;

            case OrderStatus.Paid:
                Console.WriteLine("Shipping order...");
                Status = OrderStatus.Shipped;
                break;

            case OrderStatus.Shipped:
                Console.WriteLine("Delivering order...");
                Status = OrderStatus.Delivered;
                break;

            case OrderStatus.Delivered:
                Console.WriteLine("Order is already delivered.");
                break;
        }
    }
}
