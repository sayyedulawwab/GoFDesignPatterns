namespace Facade.Bad;
public class ReportGenerator
{
    public string GenerateReport(List<string> data)
    {
        // Simulate report generation
        return string.Join("\n", data);
    }
}
