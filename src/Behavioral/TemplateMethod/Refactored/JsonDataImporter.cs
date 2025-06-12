namespace TemplateMethod.Refactored;
public class JsonDataImporter : DataImporter
{
    protected override void ReadFile()
    {
        Console.WriteLine("Reading JSON file...");
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing JSON data...");
    }
}
