namespace Singleton.Bad;
public class ConfigurationService
{
    private readonly Dictionary<string, string> _settings;

    public ConfigurationService()
    {
        // Simulate heavy I/O or file read
        _settings = new Dictionary<string, string>
        {
            ["ConnectionString"] = "Server=localhost;Database=AppDb;",
            ["ApiKey"] = "bad-api-key"
        };

        Console.WriteLine("Configuration loaded from source.");
    }

    public string Get(string key)
    {
        return _settings.TryGetValue(key, out var value) ? value : string.Empty;
    }
}
