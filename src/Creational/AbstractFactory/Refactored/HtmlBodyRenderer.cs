namespace AbstractFactory.Refactored;
public class HtmlBodyRenderer : IBodyRenderer
{
    public void Render()
    {
        Console.WriteLine("<p>This is the HTML body.</p>");
    }
}
