namespace Mediator.Refactored;
public interface IMediator
{
    void Notify(object sender, string action, string username);
}
