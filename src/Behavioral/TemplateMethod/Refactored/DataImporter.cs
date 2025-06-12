namespace TemplateMethod.Refactored;
public abstract class DataImporter
{
    public void Import()
    {
        ReadFile();
        ParseData();
        ValidateData();
        SaveToDatabase();
    }

    protected abstract void ReadFile();
    protected abstract void ParseData();

    protected virtual void ValidateData()
    {
        Console.WriteLine("Validating data...");
    }

    protected virtual void SaveToDatabase()
    {
        Console.WriteLine("Saving to database...");
    }
}
