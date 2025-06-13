namespace Flyweight.Bad;
public class UserSession
{
    public string UserId { get; }
    public UserPreference Preference { get; }

    public UserSession(string userId, string theme, string language)
    {
        UserId = userId;
        Preference = new UserPreference(theme, language); // new object every time!
    }

    public void Display()
    {
        Console.WriteLine($"User: {UserId}, Theme: {Preference.Theme}, Language: {Preference.Language}");
    }
}
