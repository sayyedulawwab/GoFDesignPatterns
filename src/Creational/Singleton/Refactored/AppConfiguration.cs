namespace Singleton.Refactored;
public sealed class AppConfiguration
{
    private static readonly Lazy<AppConfiguration> _instance =
        new(() => new AppConfiguration());

    private readonly Dictionary<string, string> _settings;

    private AppConfiguration()
    {
        // Simulate heavy config loading
        _settings = new Dictionary<string, string>
        {
            ["ConnectionString"] = "Server=localhost;Database=AppDb;",
            ["ApiKey"] = "singleton-api-key"
        };

        Console.WriteLine("Configuration loaded from source.");
    }

    public static AppConfiguration Instance => _instance.Value;

    public string Get(string key)
    {
        return _settings.TryGetValue(key, out var value) ? value : string.Empty;
    }
}
