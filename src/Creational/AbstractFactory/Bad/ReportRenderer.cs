namespace AbstractFactory.Bad;
public enum Format
{
    Html,
    PlainText
}

public class ReportRenderer
{
    private readonly Format _format;

    public ReportRenderer(Format format)
    {
        _format = format;
    }

    public void Render()
    {
        if (_format == Format.Html)
        {
            Console.WriteLine("<h1>HTML Report</h1>");
            Console.WriteLine("<p>This is the body.</p>");
        }
        else if (_format == Format.PlainText)
        {
            Console.WriteLine("=== Plain Text Report ===");
            Console.WriteLine("This is the body.");
        }
    }
}
