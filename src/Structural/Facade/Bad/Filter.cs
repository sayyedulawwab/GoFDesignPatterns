namespace Facade.Bad;
public class Filter
{
    public List<string> ApplyFilter(List<string> data)
    {
        // Simulate filtering: keep only items containing '1'
        return data.Where(d => d.Contains("1")).ToList();
    }
}
