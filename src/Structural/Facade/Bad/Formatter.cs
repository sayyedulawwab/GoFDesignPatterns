namespace Facade.Bad;
public class Formatter
{
    public List<string> Format(List<string> data)
    {
        // Simulate formatting data
        return data.Select(d => d.ToUpper()).ToList();
    }
}