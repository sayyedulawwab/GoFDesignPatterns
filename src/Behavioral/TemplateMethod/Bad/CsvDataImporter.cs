namespace TemplateMethod.Bad;
public class CsvDataImporter
{
    public void Import()
    {
        Console.WriteLine("Reading CSV file...");
        Console.WriteLine("Parsing CSV data...");
        Console.WriteLine("Validating data...");
        Console.WriteLine("Saving to database...");
    }
}
