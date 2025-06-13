namespace Bridge.Refactored;
public class InfoLogger : Logger
{
    public InfoLogger(ILogDestination destination) : base(destination) { }

    public override void Log(string message)
    {
        _destination.Send($"INFO: {message}");
    }
}
