namespace AbstractFactory.Refactored;
public class HtmlHeaderRenderer : IHeaderRenderer
{
    public void Render()
    {
        Console.WriteLine("<h1>HTML Report</h1>");
    }
}
