namespace Observer.Refactored;
public class OrderPlacedEvent
{
    public string CustomerEmail { get; set; }
    public string PhoneNumber { get; set; }

    public OrderPlacedEvent(string email, string phone)
    {
        CustomerEmail = email;
        PhoneNumber = phone;
    }
}
