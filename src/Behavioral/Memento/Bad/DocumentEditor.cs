namespace Memento.Bad;
public class DocumentEditor
{
    private string _content = "";

    public void Write(string text)
    {
        _content += text;
    }

    public void Undo(string previousContent)
    {
        _content = previousContent;
    }

    public string GetContent() => _content;
}
