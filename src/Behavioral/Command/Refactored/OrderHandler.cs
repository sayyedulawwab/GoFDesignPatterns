namespace Command.Refactored;
public class OrderHandler
{
    public void RunCommand(ICommand command)
    {
        command.Execute();
    }
}
