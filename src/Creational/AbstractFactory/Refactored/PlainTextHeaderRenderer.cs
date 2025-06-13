namespace AbstractFactory.Refactored;
public class PlainTextHeaderRenderer : IHeaderRenderer
{
    public void Render()
    {
        Console.WriteLine("=== Plain Text Report ===");
    }
}
