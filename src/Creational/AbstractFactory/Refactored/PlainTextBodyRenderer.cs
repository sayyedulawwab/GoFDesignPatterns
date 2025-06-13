namespace AbstractFactory.Refactored;
public class PlainTextBodyRenderer : IBodyRenderer
{
    public void Render()
    {
        Console.WriteLine("This is the plain text body.");
    }
}
