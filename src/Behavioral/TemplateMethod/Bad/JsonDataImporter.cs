namespace TemplateMethod.Bad;
public class JsonDataImporter
{
    public void Import()
    {
        Console.WriteLine("Reading JSON file...");
        Console.WriteLine("Parsing JSON data...");
        Console.WriteLine("Validating data...");
        Console.WriteLine("Saving to database...");
    }
}
