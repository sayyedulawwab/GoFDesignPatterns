namespace Flyweight.Refactored;
public class UserSession
{
    public string UserId { get; }
    public UserPreference Preference { get; }

    public UserSession(string userId, UserPreference preference)
    {
        UserId = userId;
        Preference = preference;
    }

    public void Display()
    {
        Console.WriteLine($"User: {UserId}, Theme: {Preference.Theme}, Language: {Preference.Language}");
    }
}
