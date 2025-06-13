namespace Memento.Refactored;
public class Document
{
    private string _content = "";

    public void Write(string text)
    {
        _content += text;
    }

    public string GetContent() => _content;

    public DocumentMemento CreateMemento()
    {
        return new DocumentMemento(_content);
    }

    public void Restore(DocumentMemento memento)
    {
        _content = memento.Content;
    }
}
