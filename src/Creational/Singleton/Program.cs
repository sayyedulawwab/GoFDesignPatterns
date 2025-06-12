using Singleton.Bad;
using Singleton.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var config1 = new ConfigurationService();
Console.WriteLine(config1.Get("ConnectionString"));

var config2 = new ConfigurationService();
Console.WriteLine(config2.Get("ApiKey"));


Console.WriteLine("\n=== REFACTORED EXAMPLE (SINGLETON) ===");
var appConfig1 = AppConfiguration.Instance;
Console.WriteLine(appConfig1.Get("ConnectionString"));

var appConfig2 = AppConfiguration.Instance;
Console.WriteLine(appConfig2.Get("ApiKey"));