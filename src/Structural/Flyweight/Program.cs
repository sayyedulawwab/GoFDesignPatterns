using Flyweight.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badSession1 = new Flyweight.Bad.UserSession("user1", "Dark", "English");
var badSession2 = new Flyweight.Bad.UserSession("user2", "Dark", "English");
badSession1.Display();
badSession2.Display();

Console.WriteLine($"\nAre preferences same instance? {ReferenceEquals(badSession1.Preference, badSession2.Preference)}");


Console.WriteLine("\n=== REFACTORED EXAMPLE (FLYWEIGHT PATTERN) ===");
var preferenceFactory = new UserPreferenceFactory();
var pref1 = preferenceFactory.GetPreference("Dark", "English");
var pref2 = preferenceFactory.GetPreference("Dark", "English");

var refSession1 = new UserSession("user1", pref1);
var refSession2 = new UserSession("user2", pref2);

refSession1.Display();
refSession2.Display();

Console.WriteLine($"\nAre preferences same instance? {ReferenceEquals(pref1, pref2)}");
