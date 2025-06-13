namespace Memento.Refactored;
public class DocumentMemento
{
    public string Content { get; }

    public DocumentMemento(string content)
    {
        Content = content;
    }
}
