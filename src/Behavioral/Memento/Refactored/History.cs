namespace Memento.Refactored;
public class History
{
    private readonly Stack<DocumentMemento> _mementos = new();

    public void Save(DocumentMemento memento)
    {
        _mementos.Push(memento);
    }

    public DocumentMemento Undo()
    {
        return _mementos.Pop();
    }
}
