namespace Bridge.Refactored;
public class FileLogDestination : ILogDestination
{
    public void Send(string formattedMessage)
    {
        Console.WriteLine($"[File] {formattedMessage}");
    }
}
