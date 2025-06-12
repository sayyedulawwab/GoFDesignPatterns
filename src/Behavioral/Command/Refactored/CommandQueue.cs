namespace Command.Refactored;
public class CommandQueue
{
    private readonly Queue<ICommand> _queue = new();

    public void AddCommand(ICommand command) => _queue.Enqueue(command);

    public void ProcessAll()
    {
        while (_queue.Any())
        {
            var cmd = _queue.Dequeue();
            cmd.Execute();
        }
    }
}
