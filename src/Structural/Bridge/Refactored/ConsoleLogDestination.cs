namespace Bridge.Refactored;
public class ConsoleLogDestination : ILogDestination
{
    public void Send(string formattedMessage)
    {
        Console.WriteLine($"[Console] {formattedMessage}");
    }
}
