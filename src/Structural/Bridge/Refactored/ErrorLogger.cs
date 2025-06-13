namespace Bridge.Refactored;
public class ErrorLogger : Logger
{
    public ErrorLogger(ILogDestination destination) : base(destination) { }

    public override void Log(string message)
    {
        _destination.Send($"ERROR: {message}");
    }
}
