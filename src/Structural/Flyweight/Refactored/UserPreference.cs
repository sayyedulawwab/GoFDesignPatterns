namespace Flyweight.Refactored;
public class UserPreference
{
    public string Theme { get; }
    public string Language { get; }

    public UserPreference(string theme, string language)
    {
        Theme = theme;
        Language = language;
    }
}
