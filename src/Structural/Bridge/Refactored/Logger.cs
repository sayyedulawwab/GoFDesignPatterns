namespace Bridge.Refactored;
public abstract class Logger
{
    protected readonly ILogDestination _destination;

    protected Logger(ILogDestination destination)
    {
        _destination = destination;
    }

    public abstract void Log(string message);
}
