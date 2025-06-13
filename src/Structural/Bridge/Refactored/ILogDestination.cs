namespace Bridge.Refactored;
public interface ILogDestination
{
    void Send(string formattedMessage);
}
