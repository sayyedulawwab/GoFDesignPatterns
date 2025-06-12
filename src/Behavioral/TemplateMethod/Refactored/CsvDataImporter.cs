namespace TemplateMethod.Refactored;
public class CsvDataImporter : DataImporter
{
    protected override void ReadFile()
    {
        Console.WriteLine("Reading CSV file...");
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing CSV data...");
    }
}
